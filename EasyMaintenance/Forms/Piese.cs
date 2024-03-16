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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EasyMaintenance.Forms
{
    //Identic cu partea de clienti sau angajati
    public partial class Piese : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-30A89AF\\SQLEXPRESS2;Initial Catalog=Mentenanta;Integrated Security=True");
        int idBox = 0;
        public Piese()
        {
            InitializeComponent();
            modiButton.Enabled = false;
            delButton.Enabled = false;
            }

        private void Piese_Load(object sender, EventArgs e)
        {
            LoadPieseGrid(null);
        }

      
        private void pieseGrid_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
                goto skip;
            DataGridViewRow selectedRow = pieseGrid.Rows[index];
            cod_sap.Text = selectedRow.Cells[2].Value.ToString();
            denumire.Text = selectedRow.Cells[1].Value.ToString();
            poz_raft.Text = selectedRow.Cells[3].Value.ToString();
            cant.Text = selectedRow.Cells[4].Value.ToString();
            cost.Text = selectedRow.Cells[5].Value.ToString();
            idBox = (int)selectedRow.Cells[0].Value;
            modiButton.Enabled = true;
            delButton.Enabled = true;
        skip:;
        }

        private void ResetInput()
        {
            denumire.Clear();
            cod_sap.Clear();
            poz_raft.Clear();
            cant.Clear();
            cost.Clear();
            cod_sap.Focus();
            modiButton.Enabled=false;
            delButton.Enabled=false;
    
        }

        private void LoadPieseGrid(String query)
        {
            if (String.IsNullOrEmpty(query))
                query = "SELECT * FROM Piese";
            DataTable dTable = new DataTable();
            try 
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dTable);
                pieseGrid.DataSource = dTable;
                pieseGrid.Columns["piesa_id"].Visible = false;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                dTable.Dispose();
                conn.Close();
            }
            for (int i = 0; i < 6; i++)
                this.pieseGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pieseGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.pieseGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO Piese (denumire, cod_sap, poz_raft, cant_depo, cost) VALUES('" + denumire.Text + "','" + cod_sap.Text + "','" + poz_raft.Text + "','" + cant.Text + "','" + Decimal.Parse(cost.Text) + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            
            if(!String.IsNullOrEmpty(denumire.Text))
            {
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
                finally 
                {
                    conn.Close();
                    LoadPieseGrid(null);
                    ResetInput();
                }
            }
            else
            {
                MessageBox.Show("Nu ati introdus o valoare pentru denumire!", "Adaugare invalida!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetInput();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM Piese WHERE piesa_id = @piesa_id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@piesa_id",idBox);

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
                    LoadPieseGrid(null);
                    ResetInput();
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
            String query = "SELECT * FROM Piese WHERE denumire LIKE '" + denumire.Text + "%" + "' AND cod_sap LIKE '" + cod_sap.Text + "%" + "' AND poz_raft LIKE '" + poz_raft.Text + "%" + "'";
            SqlCommand cmd = new SqlCommand(query, conn);

            LoadPieseGrid(query);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Piese SET denumire = @denumire, cod_sap = @cod_sap, poz_raft = @poz_raft, cant_depo = @cant_depo, cost = @cost WHERE piesa_id = @piesa_id", conn);
                cmd.Parameters.AddWithValue("@denumire", denumire.Text);
                cmd.Parameters.AddWithValue("@cod_sap", cod_sap.Text);
                cmd.Parameters.AddWithValue("@poz_raft", poz_raft.Text);
                cmd.Parameters.AddWithValue("@cant_depo",int.Parse(cant.Text));
                cmd.Parameters.AddWithValue("@cost", Decimal.Parse(cost.Text));
                cmd.Parameters.AddWithValue("@piesa_id", idBox);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                ResetInput();
                LoadPieseGrid(null);
                modiButton.Enabled = false;
                delButton.Enabled = false;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResetInput();
            LoadPieseGrid(null);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
