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
    public partial class Lista_operatii : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-30A89AF\\SQLEXPRESS2;Initial Catalog=Mentenanta;Integrated Security=True");
        int idBox = 0;
        public Lista_operatii()
        {
            InitializeComponent();
            addOperatii.Enabled = false;
            addOperatii.Visible = false;
            delOperatii.Enabled = false;
            delOperatii.Visible = false;
            addLista.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lista_operatii_Load(object sender, EventArgs e)
        {
            LoadLOperatiiGrid(null);
        }
        private void LoadLOperatiiGrid(String query)
        {
            if (String.IsNullOrEmpty(query))
                query = "SELECT * FROM ListaOper";
            DataTable dTable = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dTable);
                lOperatiiGrid.DataSource = dTable;
                lOperatiiGrid.Columns["loper_id"].Visible = false;
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
            for (int i = 0; i < 2; i++)
                this.lOperatiiGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lOperatiiGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void LoadOperatiiGrid(String query)
        {
            if (String.IsNullOrEmpty(query))
                query = "SELECT Operatie.denumire, Operatie.instructiune, Operatie.scule_spec, Operatie.aplic_prev, Operatie.aplic_corect, Operatie.durata FROM ListaOper_Oper JOIN Operatie ON ListaOper_Oper.operatie_id = Operatie.operatie_id WHERE ListaOper_Oper.loper_id = '" + idBox + "'";

            DataTable dTable = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dTable);
                operatiiGrid.DataSource = dTable;
                //pieseGrid.Columns["piesa_id"].Visible = false;
                //pieseGrid.Columns["piesa_id1"].Visible = false;
                //pieseGrid.Columns["lpiesa_id"].Visible = false;
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
            for (int i = 0; i < 6; i++)
                this.operatiiGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.pieseGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.pieseGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.pieseGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.operatiiGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void lOperatiiGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addOperatii.Enabled = true;
            delOperatii.Enabled = true;
            int index = e.RowIndex;
            if (index < 0)
                goto skip;
            DataGridViewRow selectedRow = lOperatiiGrid.Rows[index];

            idBox = (int)selectedRow.Cells[0].Value;
            LoadOperatiiGrid(null);
            LoadStatisticGrid();
        skip:;
        }

        private void LoadStatisticGrid()
        {
            ResetStatisticInput();

            String query1 = "SELECT ISNULL(Suma,0) FROM (SELECT SUM(Operatie.durata) AS Suma FROM ListaOper_Oper JOIN Operatie ON ListaOper_Oper.operatie_id = Operatie.operatie_id WHERE ListaOper_Oper.loper_id = '" + idBox + "') AS R";
            //interogare simpla nr6
            String query2 = "SELECT ISNULL(Maxim,0) FROM (SELECT Max(Operatie.durata) AS Maxim FROM ListaOper_Oper JOIN Operatie ON ListaOper_Oper.operatie_id = Operatie.operatie_id WHERE ListaOper_Oper.loper_id = '" + idBox + "') AS R";
            //interogare complexa nr4
            
            DataTable dTable1 = new DataTable();
            DataTable dTable2 = new DataTable();
            
            try
            {
                conn.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, conn);
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, conn);
                sda1.Fill(dTable1);
                sda2.Fill(dTable2);
                durataLista.Text = dTable1.Rows[0].Field<decimal>(0).ToString();
                durataMaxim.Text = dTable2.Rows[0].Field<decimal>(0).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dTable1.Dispose();
                dTable2.Dispose();
                conn.Close();
            }
        }

        private void ResetStatisticInput()
        {
            durataLista.Clear();
            durataMaxim.Clear();
        }

    }
}
