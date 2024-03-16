using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EasyMaintenance.Forms
{
    public partial class Angajati : Form
    {
        //Conexiunea la baza de date de pe serverul local
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-30A89AF\\SQLEXPRESS2;Initial Catalog=Mentenanta;Integrated Security=True");
        
        //Aici facem o variabila globala pentru a tine minte id-ul angajatului, pentru ca nu vrem sa-l afisam in interfata
        int idBox = 0;
        public Angajati()
        {
            InitializeComponent();

            //Incepem cu butoanele dezactivate, abia dupa ce apasam se activeaza, cu toate ca aici nu
            modiButton.Enabled = false;
            delButton.Enabled = false;
        }

        private void Angajati_Load(object sender, EventArgs e)
        {

            //Incarcare dinamica a tabelului, fie dupa un query usor si simplu, fie dupa ceva anume
            LoadAngajatiGrid(null);

        }

        //Partea de statistici pentru un client anume, care utilizeaza username-ul fiind unic
        private void LoadStatisticGrid()
        {
            //int thisMonth = DateTime.Now.Month;
            ResetStatisticInput();
            String query1 = "SELECT COUNT(*) FROM User_Echip WHERE User_Echip.username LIKE '" + username.Text + "'";
            String query2 = "SELECT TOP 1 User_Echip.data_incep FROM User_Echip WHERE User_Echip.username LIKE '" + username.Text + "'ORDER BY User_Echip.data_incep ASC";
            DataTable dTable1 = new DataTable();
            DataTable dTable2 = new DataTable();
            DataTable dTable3 = new DataTable();
            DataTable dTable4 = new DataTable();
            //interogare simpla nr4
            String query3 = "SELECT TOP 1 Client.Denumire FROM Client INNER JOIN Echipament ON Echipament.client=Client.client_id INNER JOIN User_Echip ON User_Echip.echip_id = Echipament.echip_id WHERE User_Echip.username LIKE '" + username.Text + "' ORDER BY User_Echip.data_incep ASC";
            //interogare complexa nr2
            String query4 = "SELECT R.denumire, R.NumarOp1 FROM (SELECT Operatie.denumire, COUNT(*) NumarOp1 FROM Tichet JOIN ListaOper_Oper ON lista_oper = loper_id JOIN Operatie ON ListaOper_Oper.operatie_id = Operatie.operatie_id WHERE initiator LIKE '" + username.Text + "' GROUP BY Operatie.denumire) AS R WHERE R.NumarOp1 = ( SELECT R1.NumarOp FROM (SELECT TOP 1 O1.denumire, COUNT(*) AS NumarOp FROM Tichet T1 JOIN ListaOper_Oper LOO1 ON T1.lista_oper = LOO1.loper_id JOIN Operatie O1 ON LOO1.operatie_id = O1.operatie_id WHERE initiator LIKE '" + username.Text + "' GROUP BY O1.denumire ORDER BY NumarOp DESC) AS R1)";
            
            //folosim blocul try-catch-except pentru ca e posibil sa nu se poata realiza conexiunea cu baza de date
            try
            {
                conn.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, conn);
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, conn);
                SqlDataAdapter sda3 = new SqlDataAdapter(query3, conn);
                SqlDataAdapter sda4 = new SqlDataAdapter(query4, conn);
                sda1.Fill(dTable1);
                sda2.Fill(dTable2);
                sda3.Fill(dTable3);
                sda4.Fill(dTable4);

                //Salvam rezultatele in casutele care ne interesaza
                nrEchip.Text = dTable1.Rows[0].Field<int>(0).ToString();
                if (dTable2.Rows.Count == 0)
                    incepereActivitate.Text = "N/A";
                else
                    incepereActivitate.Text = dTable2.Rows[0].Field<DateTime>(0).ToString();
                if (dTable3.Rows.Count == 0)
                    primulClient.Text = "N/A";
                else
                    primulClient.Text = dTable3.Rows[0].Field<String>(0);
                if (dTable4.Rows.Count == 0)
                {
                    opPref.Text = "N/A";
                    nrAplic.Text = "N/A";
                }
                else
                {
                    nrAplic.Text = dTable4.Rows[0].Field<int>(1).ToString();
                    for (int i = 0; i < dTable4.Rows.Count; i++)
                    {
                        opPref.AppendText(dTable4.Rows[i].Field<String>(0).ToString() + "\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Scapam de tabelele pe care le-am folosit si inchidem conexiunea
                dTable1.Dispose();
                dTable2.Dispose();
                dTable3.Dispose();
                dTable4.Dispose();
                conn.Close();
            }
        }

        private void LoadAngajatiGrid(String query)
        {
            if (String.IsNullOrEmpty(query))
                query = "SELECT * FROM User1";
            DataTable dTable = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dTable);
                angajatiGrid.DataSource = dTable;
                angajatiGrid.Columns["user_id"].Visible = false;
                angajatiGrid.Columns["angajat_id"].Visible = false; 
                angajatiGrid.Columns["parola"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dTable.Dispose();
                conn.Close();
            }

            //Realizam o mai buna incadrare a coloanelor, una dinamica care tine cont de cele mai importante date
            for (int i = 0; i < 3; i++)
                this.angajatiGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //this.angajatiGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.angajatiGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void angajatiGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Aici incarcam ce avem nevoie dupa ce apasam in tabelul cu useri
            int index = e.RowIndex;
            if (index < 0)
                goto skip;
            DataGridViewRow selectedRow = angajatiGrid.Rows[index];
            username.Text = selectedRow.Cells[1].Value.ToString();
            nivel_acc.Text = selectedRow.Cells[3].Value.ToString();
            idBox = (int)selectedRow.Cells[0].Value;
            modiButton.Enabled = true;
            delButton.Enabled = true;
            //activam butoanele deoarece putem sa le folosim, chiar daca nu aici
        skip:;
            LoadStatisticGrid();
        }

        private void ResetInput()
        {
            username.Clear();
            nivel_acc.Clear();
            modiButton.Enabled = false;
            delButton.Enabled = false;

        }
        private void ResetStatisticInput()
        {
            nrEchip.Clear();
            incepereActivitate.Clear();
            primulClient.Clear();
            opPref.Clear();
            nrAplic.Clear();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO User1 (username, parola, nivel_acc, angajat_id) VALUES(@username, @username, @nivel_acc, @angajat_id)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username.Text);
            cmd.Parameters.AddWithValue("@nivel_acc", nivel_acc.Text);
            //cmd.Parameters.AddWithValue("@angajat_id", nivel_acc.Text);

            if (!String.IsNullOrEmpty(username.Text))
            {
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    conn.Close();
                    LoadAngajatiGrid(null);
                    ResetInput();
                    //ResetStatisticInput();
                }
            }
            else
            {
                MessageBox.Show("Nu ati introdus o valoare pentru denumire!", "Adaugare invalida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetInput();
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM User1 WHERE user_id = @client_id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@client_id", idBox);

            if (!String.IsNullOrEmpty(username.Text))
            {
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    LoadAngajatiGrid(null);
                    ResetInput();
                    //ResetStatisticInput();
                }
            }
            else
            {
                MessageBox.Show("Nu ati introdus o valoare pentru denumire!", "Adaugare invalida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetInput();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM User1 WHERE username LIKE '" + username.Text + "%" + "'";

            if (!String.IsNullOrEmpty(username.Text))
            {
                LoadAngajatiGrid(query);
            }
            else
            {
                LoadAngajatiGrid(null);
            }
        }

        private void modiButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                //Comanda cu parametri dinamici
                SqlCommand cmd = new SqlCommand("UPDATE User1 SET username = @denumire, user_acc = @user_acc,  WHERE user_id = @user_id", conn);
                cmd.Parameters.AddWithValue("@denumire", username.Text);
                cmd.Parameters.AddWithValue("@user_acc", nivel_acc.Text);
                cmd.Parameters.AddWithValue("@user_id", idBox);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                ResetInput();
                //ResetStatisticInput();
                LoadAngajatiGrid(null);
                modiButton.Enabled = false;
                delButton.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetInput();
            ResetStatisticInput();
            LoadAngajatiGrid(null);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
