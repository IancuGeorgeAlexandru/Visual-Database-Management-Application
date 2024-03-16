using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyMaintenance.Forms
{
    public partial class Echipamente : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-30A89AF\\SQLEXPRESS2;Initial Catalog=Mentenanta;Integrated Security=True");

        public Echipamente()
        {
            InitializeComponent();
            
        }

        private void Echipamente_Load(object sender, EventArgs e)
        {
            LoadEchipGrid(null);
            String querry = "SELECT denumire FROM Client";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
            DataTable dTable = new DataTable();
            sda.Fill(dTable);

            client.DataSource = dTable;
            client.ValueMember = "denumire";

            querry = "SELECT username FROM User1";
            sda = new SqlDataAdapter(querry, conn);
            dTable = new DataTable();
            sda.Fill(dTable);

            responsabil.DataSource = dTable;
            responsabil.ValueMember = "username";

            //Aici citesc toate valorile din operatii pentru a putea afisa si numele si versiunea si similar la piese

            querry = "SELECT CONCAT(denumire, '  -->  ', versiune) AS denumire FROM ListaOper";
            sda = new SqlDataAdapter(querry, conn);
            dTable = new DataTable();
            sda.Fill(dTable);

            lista_oper.DataSource = dTable;
            lista_oper.ValueMember = "denumire";

            querry = "SELECT CONCAT(denumire, '  -->  ', versiune) AS denumire FROM ListaPiese";
            sda = new SqlDataAdapter(querry, conn);
            dTable = new DataTable();
            sda.Fill(dTable);

            lista_piese.DataSource = dTable;
            lista_piese.ValueMember = "denumire";
        }

        private void LoadEchipGrid(String query)
        {
            if (String.IsNullOrEmpty(query))
                query = "SELECT * FROM Echipament";
            DataTable dTable = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dTable);
                echipGrid.DataSource = dTable;
                echipGrid.Columns["echip_id"].Visible = false;
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
            for (int i = 0; i < 8; i++)
                this.echipGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.echipGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Echipament (cod, denumire, tip, preventiva, client, lista_oper, lista_piese) VALUES(@cod, @denumire, @tip, @preventiva, @client, @lista_oper, @lista_piese)", conn);
            cmd.Parameters.AddWithValue("@cod", int.Parse(cod.Text));
            cmd.Parameters.AddWithValue("@denumire", denumire.Text);
            cmd.Parameters.AddWithValue("@tip", tip.Text);
            cmd.Parameters.AddWithValue("@preventiva", preventiva.Text);
            cmd.Parameters.AddWithValue("@client", int.Parse(client.Text));
            cmd.Parameters.AddWithValue("@lista_oper", int.Parse(lista_oper.Text));
            cmd.Parameters.AddWithValue("@lista_piese", int.Parse(lista_piese.Text));

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
                    LoadEchipGrid(null);

                    //TODO 
                    String querry = "SELECT echip_id FROM Echipament WHERE cod LIKE '" + decimal.Parse(cod.Text) + "' AND denumire LIKE  '" +  denumire.Text+"' AND responsabil LIKE '" + responsabil.Text+ "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                    DataTable dTable = new DataTable();
                    sda.Fill(dTable);

                    //int echip_id =;
                    //SqlCommand cmd = new SqlCommand("INSERT INTO Echipament (cod, denumire, tip, preventiva, client, lista_oper, lista_piese) VALUES(@cod, @denumire, @tip, @preventiva, @client, @lista_oper, @lista_piese)", conn);


                    resetInput();
                }
            }
            else
            {
                MessageBox.Show("Nu ati introdus o valoare pentru denumire!", "Adaugare invalida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resetInput();
            }
        }

        private void resetInput()
        {
            cod.Clear();
            denumire.Clear();
            //client.Clear();
            preventiva.Clear();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void client_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void responsabil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
