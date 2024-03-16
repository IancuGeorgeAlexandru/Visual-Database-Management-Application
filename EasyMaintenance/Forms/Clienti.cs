using System;
using System.Collections;
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

namespace EasyMaintenance.Forms
{
    public partial class Clienti : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-30A89AF\\SQLEXPRESS2;Initial Catalog=Mentenanta;Integrated Security=True");
        int idBox=0;
        public Clienti()
        {
            InitializeComponent();
            modiButton.Enabled = false;
            delButton.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void Clienti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mentenantaDataSet4.Client' table. You can move, or remove it, as needed.
            //this.clientTableAdapter2.Fill(this.mentenantaDataSet4.Client);
            //// TODO: This line of code loads data into the 'mentenantaDataSet3.Client' table. You can move, or remove it, as needed.
            //this.clientTableAdapter1.Fill(this.mentenantaDataSet3.Client);
            LoadClientiGrid(null);
            
        }

        private void LoadClientiGrid(String query)
        {
            if (String.IsNullOrEmpty(query))
                query = "SELECT * FROM Client";
            DataTable dTable = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dTable);
                clientiGrid.DataSource = dTable;
                clientiGrid.Columns["client_id"].Visible = false;
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
            for (int i = 0; i < 4; i++)
                this.clientiGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clientiGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
            this.clientiGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void loadStatisticiGrid(int idBox)
        {
            int thisMonth = DateTime.Now.Month;
            //int thisMonth = 1;
            ResetStatisticInput();
            String query1 = "SELECT COUNT(*) FROM Echipament WHERE client = '" + idBox + "'";
            // interogare simpla nr1
            String query2 = "SELECT COUNT(*) FROM Tichet INNER JOIN Echipament ON Tichet.echipament = Echipament.echip_id WHERE Echipament.client = '" + idBox + "'";
            // interogare simpla nr2
            String query3 = "SELECT COUNT(*) FROM Tichet INNER JOIN Echipament ON Tichet.echipament = Echipament.echip_id WHERE Echipament.client = '" + idBox + "' AND Tichet.status LIKE 'Activ'";
            // interogare simpla nr3
            String query4 = "SELECT TOP 1 User_Echip.data_incep FROM Echipament INNER JOIN User_Echip ON User_Echip.echip_id = Echipament.echip_id WHERE Echipament.client = '" + idBox + "' ORDER BY User_Echip.data_incep ASC";
            //interogare complexa nr1
            String query5 = "SELECT Luna_Echip.nume_luna, Echipament.denumire FROM Luna_Echip JOIN Echipament ON Luna_Echip.echip_id = Echipament.echip_id WHERE Echipament.client = '" + idBox + "' AND Luna_Echip.nume_luna IN (SELECT TOP 1 LE1.nume_luna FROM Luna L1 JOIN Luna_Echip LE1 ON L1.nume = LE1.nume_luna  JOIN Echipament E1 ON LE1.echip_id = E1.echip_id WHERE E1.client = '" + idBox + "' AND L1.index_luna >= '" + thisMonth + "' ORDER BY L1.index_luna)";

            DataTable dTable1 = new DataTable();
            DataTable dTable2 = new DataTable();
            DataTable dTable3 = new DataTable();
            DataTable dTable4 = new DataTable();
            DataTable dTable5 = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, conn);
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, conn);
                SqlDataAdapter sda3 = new SqlDataAdapter(query3, conn);
                SqlDataAdapter sda4 = new SqlDataAdapter(query4, conn);
                SqlDataAdapter sda5 = new SqlDataAdapter(query5, conn);
                sda1.Fill(dTable1);
                sda2.Fill(dTable2);
                sda3.Fill(dTable3);
                sda4.Fill(dTable4);
                sda5.Fill(dTable5);

                nrEchip.Text = dTable1.Rows[0].Field<int>(0).ToString();
                nrTichete.Text = dTable2.Rows[0].Field<int>(0).ToString();
                nrTicheteActive.Text = dTable3.Rows[0].Field<int>(0).ToString();
                if (dTable4.Rows.Count == 0)
                    incepereActivitate.Text = "N/A";
                else
                    incepereActivitate.Text = dTable4.Rows[0].Field<DateTime>(0).ToString();
                if (dTable5.Rows.Count == 0)
                {
                    luna.Text = "N/A";
                    echipament.Text = "N/A";
                }
                else
                {
                    luna.Text = dTable5.Rows[0].Field<String>(0).ToString();
                    for(int i = 0;i< dTable5.Rows.Count; i++)
                    {
                        echipament.AppendText(dTable5.Rows[i].Field<String>(1).ToString() + "\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dTable1.Dispose();
                dTable2.Dispose();
                dTable3.Dispose();
                dTable4.Dispose();
                dTable5.Dispose();
                conn.Close();
            }
        }

        private void clientiGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
                goto skip;
            DataGridViewRow selectedRow = clientiGrid.Rows[index];
            denumire.Text = selectedRow.Cells[1].Value.ToString();
            oras.Text = selectedRow.Cells[2].Value. ToString();
            strada.Text = selectedRow.Cells[3].Value.ToString();
            numar.Text = selectedRow.Cells[4].Value.ToString();
            idBox = (int)selectedRow.Cells[0].Value;
            modiButton.Enabled = true;
            delButton.Enabled = true;
        skip:;

            loadStatisticiGrid(idBox);
        }

        private void ResetInput()
        {
            denumire.Clear();
            oras.Clear();
            strada.Clear();
            numar.Clear();
            denumire.Focus();
            modiButton.Enabled = false;
            delButton.Enabled = false;
            
        }

        private void ResetStatisticInput()
        {
            nrEchip.Clear();
            nrTichete.Clear();
            nrTicheteActive.Clear();
            incepereActivitate.Clear();
            luna.Clear();
            echipament.Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO Client (denumire, oras, strada, numar) VALUES(@denumire, @oras, @strada, @numar)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@denumire",denumire.Text);
            cmd.Parameters.AddWithValue("@oras", oras.Text);
            cmd.Parameters.AddWithValue("@strada",strada.Text);
            cmd.Parameters.AddWithValue("@numar",numar.Text);

            if (!String.IsNullOrEmpty(denumire.Text))
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
                    LoadClientiGrid(null);
                    ResetInput();
                    ResetStatisticInput();
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
            String query = "DELETE FROM Client WHERE client_id = @client_id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@client_id", idBox);

            if (!String.IsNullOrEmpty(denumire.Text))
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
                    LoadClientiGrid(null);
                    ResetInput();
                    ResetStatisticInput();
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
            String query = "SELECT * FROM Client WHERE denumire LIKE '" + denumire.Text + "%" + "' AND oras LIKE '" + oras.Text + "%" + "'";

                LoadClientiGrid(query);

        }

        private void modiButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Client SET denumire = @denumire, oras = @oras, strada = @strada, numar = @numar  WHERE client_id = @client_id", conn);
                cmd.Parameters.AddWithValue("@denumire", denumire.Text);
                cmd.Parameters.AddWithValue("@oras", oras.Text);
                cmd.Parameters.AddWithValue("@strada", strada.Text);
                cmd.Parameters.AddWithValue("@numar", int.Parse(numar.Text));
                cmd.Parameters.AddWithValue("@client_id", idBox);
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
                ResetStatisticInput();
                LoadClientiGrid(null);
                modiButton.Enabled = false;
                delButton.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetInput();
            ResetStatisticInput();
            LoadClientiGrid(null);
        }
    }
}
