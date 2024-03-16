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
    public partial class Tickete : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-30A89AF\\SQLEXPRESS2;Initial Catalog=Mentenanta;Integrated Security=True");
        int idBox = 0;
        public Tickete()
        {
            InitializeComponent();
            colorGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tichetGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
                goto skip;
            DataGridViewRow selectedRow = tichetGrid.Rows[index];

            //dupa ce dau click, dau fill la casutele care ma intereseaza
            idBox = (int)selectedRow.Cells[0].Value;
            data.Text = selectedRow.Cells[1].Value.ToString();
            initiator.Text = selectedRow.Cells[2].Value.ToString();
            tipInterv.Text = selectedRow.Cells[3].Value.ToString();
            categorie.Text = selectedRow.Cells[4].Value.ToString();
            denumire.Text = selectedRow.Cells[5].Value.ToString();
            descriere.Text = selectedRow.Cells[6].Value.ToString();
            termen.Text = selectedRow.Cells[7].Value.ToString();
            status.Text = selectedRow.Cells[8].Value.ToString();
            lOperatii.Text = selectedRow.Cells[9].Value.ToString();
            lPiese.Text = selectedRow.Cells[10].Value.ToString();
        skip:
            colorGrid();
            findId();
        }

        private void Tickete_Load(object sender, EventArgs e)
        {
            LoadTichetGrid(null);
        }

        private void LoadTichetGrid(String query)
        {
            if (String.IsNullOrEmpty(query))
                query = "SELECT * FROM Tichet";
            DataTable dTable = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dTable);
                tichetGrid.DataSource = dTable;
                tichetGrid.Columns["tiched_id"].Visible = false;
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
            for (int i = 0; i < 7; i++)
                this.tichetGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //this.tichetGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.tichetGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void findId()
        {
            // aici aflua valoarea exacta, dupa id-ul fiecaruia
            // pentru ca nu ma intereseaza id-ul ci denumirea acestuia 
            // foarte similar cu functia de statistici din form-urile anterioare

            String query1 = "SELECT denumire FROM Echipament WHERE echip_id = '" + denumire.Text+"'";
            String query2 = "SELECT denumire FROM ListaOper WHERE loper_id = '" + lOperatii.Text + "'";
            String query3 = "SELECT denumire FROM ListaPiese WHERE lpiese_id = '" + lPiese.Text + "'";
            String query4 = "SELECT Client.denumire FROM Echipament INNER JOIN Client ON Echipament.client = Client.client_id WHERE Echipament.echip_id = '" + idBox+ "'";

            DataTable dTable1 = new DataTable();
            DataTable dTable2 = new DataTable();
            DataTable dTable3 = new DataTable();
            DataTable dTable4 = new DataTable();    

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

                denumire.Text = dTable1.Rows[0].Field<String>(0).ToString();
                if(dTable2.Rows.Count!=0)
                    lOperatii.Text = dTable2.Rows[0].Field<String>(0).ToString();
                if(dTable3.Rows.Count!=0)
                    lPiese.Text = dTable3.Rows[0].Field<String>(0).ToString();
                if (dTable4.Rows.Count != 0)
                    client.Text = dTable4.Rows[0].Field<String>(0).ToString();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dTable1.Dispose();
                dTable2.Dispose();
                dTable3.Dispose();
                conn.Close();
            }


        }



        private void colorGrid()
        {
            //if(tichetGrid!=null)
            for (int i = 0; i < tichetGrid.Rows.Count; i++)
            {
                    if (tichetGrid.Rows[i].Cells[8].Value != null && tichetGrid.Rows[i].Cells[8].Value.ToString().Equals("Activ") == true)
                        tichetGrid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    else
                        tichetGrid.Rows[i].DefaultCellStyle.BackColor = Color.Green;
            }
        }
    }
}
