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
    public partial class DevTools : Form
    {
        //Am aici o pagina pentru developeri, unde pot trimite direct un query la baza de date si pot afisa ce primesc
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-30A89AF\\SQLEXPRESS2;Initial Catalog=Mentenanta;Integrated Security=True");

        public DevTools()
        {
            InitializeComponent();
            status.Text = "NOT GOOD";
            status.ForeColor = Color.Red;
            closeConn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                status.Text = "OK";
                status.ForeColor = Color.Green;
                openConn.Enabled = false;
                closeConn.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                status.Text = "NOT GOOD";
                status.ForeColor = Color.Red;
                closeConn.Enabled = false;
                openConn.Enabled= true;
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
            try
            {
                if (status.Text == "OK")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(query.Text, conn);
                    sda.Fill(dTable);
                    devGrid.DataSource = dTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dTable.Dispose();
            }
        }

        private void resetQuery_Click(object sender, EventArgs e)
        {
            query.Text = string.Empty;
        }

        private void DevTools_Load(object sender, EventArgs e)
        {

        }
    }
}
