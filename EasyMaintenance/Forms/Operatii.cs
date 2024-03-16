using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace EasyMaintenance.Forms
{
    public partial class Operatii : Form
    {
        //Identic cu partea de piese

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-30A89AF\\SQLEXPRESS2;Initial Catalog=Mentenanta;Integrated Security=True");
        int idBox = 0;
        public Operatii()
        {
            InitializeComponent();
            modiButton.Enabled = false;
            delButton.Enabled = false;
        }

        private void Operatii_Load(object sender, EventArgs e)
        {
            LoadOpGrid(null);
        }

        private void LoadOpGrid(String query)
        {
            if (String.IsNullOrEmpty(query))
                query = "SELECT * FROM Operatie";
            DataTable dTable = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dTable);
                opGrid.DataSource = dTable;
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
                goto skip;
            DataGridViewRow selectedRow = opGrid.Rows[index];
            denumire.Text = selectedRow.Cells[1].Value.ToString();
            instruct.Text = selectedRow.Cells[2].Value.ToString();
            scule_spec.Text = selectedRow.Cells[3].Value.ToString();
            idBox = (int)selectedRow.Cells[0].Value;
            
            aplic_corect.Checked = false;
            aplic_prev.Checked = false;
            if (selectedRow.Cells[4].Value.Equals(true))
                aplic_prev.Checked = true;
            if (selectedRow.Cells[5].Value.Equals(true))
                aplic_corect.Checked = true;

            durata.Text = selectedRow.Cells[6].Value.ToString();
            modiButton.Enabled = true;
            delButton.Enabled = true;
        skip:;
        }

        private void ResetInput()
        {
            denumire.Clear();
            instruct.Clear();
            scule_spec.Clear();
            aplic_prev.Checked=false;
            aplic_corect.Checked=false;
            durata.Clear();
            denumire.Focus();
            modiButton.Enabled = false;
            delButton.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Operatie (denumire, instructiune, scule_spec, aplic_prev, aplic_corect, durata) VALUES(@denumire, @instruct, @scule_spec, @aplic_prev, @aplic_corect, @durata)",conn);
            cmd.Parameters.AddWithValue("@denumire",denumire.Text);
            cmd.Parameters.AddWithValue("@instruct", instruct.Text);
            cmd.Parameters.AddWithValue("@scule_spec", scule_spec.Text);
            cmd.Parameters.AddWithValue("@aplic_prev", aplic_prev.Checked);
            cmd.Parameters.AddWithValue("@aplic_corect", aplic_corect.Checked);
            cmd.Parameters.AddWithValue("@durata", decimal.Parse(durata.Text));

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
                    LoadOpGrid(null);
                    ResetInput();
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
            String query = "DELETE FROM Operatie WHERE operatie_id = @operatie_id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@operatie_id", idBox);

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
                    LoadOpGrid(null);
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
            String query = "SELECT * FROM Operatie WHERE denumire LIKE '" + denumire.Text + "%" + "'";
            SqlCommand cmd = new SqlCommand(query, conn);

            if (!String.IsNullOrEmpty(denumire.Text))
            {
                LoadOpGrid(query);
            }
            else
            {
                LoadOpGrid(null);
            }
        }

        private void modiButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Operatie SET denumire = @denumire, instructiune = @instruct, scule_spec = @scule_spec, aplic_prev = @aplic_prev, aplic_corect = @aplic_corect, durata = @durata WHERE operatie_id = @operatie_id", conn);
                cmd.Parameters.AddWithValue("@denumire", denumire.Text);
                cmd.Parameters.AddWithValue("@instruct", instruct.Text);
                cmd.Parameters.AddWithValue("@scule_spec", scule_spec.Text);
                cmd.Parameters.AddWithValue("@aplic_prev", aplic_prev.Checked);
                cmd.Parameters.AddWithValue("@aplic_corect", aplic_corect.Checked);
                cmd.Parameters.AddWithValue("@durata", decimal.Parse(durata.Text));
                cmd.Parameters.AddWithValue("@operatie_id",idBox);
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
                LoadOpGrid(null);
                modiButton.Enabled = false;
                delButton.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetInput();
            LoadOpGrid(null);
        }
    }
}
