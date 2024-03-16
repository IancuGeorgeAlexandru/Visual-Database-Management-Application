using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EasyMaintenance.Forms
{

    public partial class Lista_piese : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-30A89AF\\SQLEXPRESS2;Initial Catalog=Mentenanta;Integrated Security=True");
        int idBoxLista = 0;
        int idBoxPiesa = 0;
        int contAdd = 2;
        int contDel= 2;
        int contAddList = 2;
        int contModif = 2;
        int contModifCant = 2;

        //Aici am un contor pentru fiecare operatie, pentru a ma forta sa termin o operatie, odata ce am inceput-o
        // pentru a nu trece dintr-o operatie in alta, teoretic o separare a functiilor
        public Lista_piese()
        {
            InitializeComponent();
            EnableButtons(0);
            addLista.Enabled = true;

        }

        private void Lista_piese_Load(object sender, EventArgs e)
        {
            LoadLPieseGrid(null);
        }

        private void LoadLPieseGrid(String query)
        {
            if (String.IsNullOrEmpty(query))
                query = "SELECT * FROM ListaPiese";
            DataTable dTable = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dTable);
                lPieseGrid.DataSource = dTable;
                lPieseGrid.Columns["lpiese_id"].Visible = false;
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
                this.lPieseGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.lPieseGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void LoadPieseGrid(String query)
        {
            int help = 0;
            if (String.IsNullOrEmpty(query))
            {
                query = "SELECT Piese.denumire, Piese.cod_sap, Piese.poz_raft, Piese.cant_depo, Piese.cost, ListaPiese_Piese.cant_nec FROM ListaPiese_Piese JOIN Piese ON ListaPiese_Piese.piesa_id = Piese.piesa_id WHERE ListaPiese_Piese.lpiesa_id = '" + idBoxLista + "'";
                help = 1;
            }
            DataTable dTable = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                sda.Fill(dTable);
                pieseGrid.DataSource = dTable;
                if (help == 0)
                {
                    pieseGrid.Columns["piesa_id"].Visible = false;
                }
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
                this.pieseGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pieseGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.pieseGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableButtons(1);
            int index = e.RowIndex;
            if (index < 0)
                goto skip;
            DataGridViewRow selectedRow = lPieseGrid.Rows[index];

            idBoxLista = (int)selectedRow.Cells[0].Value;

            piesaAdaugataLbl.Text = "Denumire: ";
            piesaAdaugata.Text = selectedRow.Cells[1].Value.ToString();
            cantitateLbl.Text = "Versiune: ";
            cantitate.Text = selectedRow.Cells[2].Value.ToString();

            //aici dupa ce dau click pe o lista, imi afiseaza separat denumire si vseriunea sa

            LoadPieseGrid(null);
            LoadStatisticGrid();
        skip:;
        }

        private void LoadStatisticGrid()
        {
            ResetStatisticInput();

            String query1 = "SELECT ISNULL(Suma,0) FROM (SELECT SUM(ListaPiese_Piese.cant_nec*Piese.cost) AS Suma FROM ListaPiese_Piese JOIN Piese ON ListaPiese_Piese.piesa_id = Piese.piesa_id WHERE ListaPiese_Piese.lpiesa_id = '" + idBoxLista + "') AS R";
            //interogare simpla nr5
            String query2 = "SELECT ISNULL(Maxim,0) FROM (SELECT MAX(ListaPiese_Piese.cant_nec*Piese.cost) AS Maxim FROM ListaPiese_Piese JOIN Piese ON ListaPiese_Piese.piesa_id = Piese.piesa_id WHERE ListaPiese_Piese.lpiesa_id = '" + idBoxLista + "') AS R";
            //interogare complexa nr3
            String query3 = "SELECT ISNULL(Medie,0) FROM (SELECT AVG(ListaPiese_Piese.cant_nec*Piese.cost) AS Medie FROM ListaPiese_Piese JOIN Piese ON ListaPiese_Piese.piesa_id = Piese.piesa_id WHERE ListaPiese_Piese.lpiesa_id = '" + idBoxLista + "') AS R";

            DataTable dTable1 = new DataTable();
            DataTable dTable2 = new DataTable();
            DataTable dTable3 = new DataTable();

            try
            {
                conn.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter(query1, conn);
                SqlDataAdapter sda2 = new SqlDataAdapter(query2, conn);
                SqlDataAdapter sda3 = new SqlDataAdapter(query3, conn);
                sda1.Fill(dTable1);
                sda2.Fill(dTable2);
                sda3.Fill(dTable3);
                pretLista.Text = dTable1.Rows[0].Field<decimal>(0).ToString();
                pretMaxim.Text = dTable2.Rows[0].Field<decimal>(0).ToString();
                pretMediu.Text = Math.Round(dTable3.Rows[0].Field<decimal>(0), 3).ToString();

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
                conn.Close();
            }
        }

        private void ResetStatisticInput()
        {
            pretLista.Clear();
            pretMaxim.Clear();
            pretMediu.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (contAdd == 2)
            {
                EnableButtons(0);
                addPiese.Enabled = true;
                String query = "SELECT * FROM Piese WHERE Piese.piesa_id NOT IN ( SELECT P1.piesa_id FROM Piese P1 INNER JOIN ListaPiese_Piese LPP1 ON P1.piesa_id = LPP1.piesa_id WHERE LPP1.lpiesa_id = '" + idBoxLista + "')";
                LoadPieseGrid(query);
                contAdd--;
                addPiese.BackColor = Color.Green;
                cantitateLbl.Text = "Cantitate: ";
            }
            else if(contAdd == 1)
            {
                addPiesaLista();
                LoadStatisticGrid();
                contAdd = 2;
                addPiese.BackColor = DefaultBackColor;
                ResetInput();
                EnableButtons(1);
            }


        }

        private void pieseGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0)
                goto skip;
            DataGridViewRow selectedRow = pieseGrid.Rows[index];

            if (contAdd != 2 || contDel != 2 || contModifCant != 2)
            {
                idBoxPiesa = (int)selectedRow.Cells[0].Value;
                piesaAdaugata.Text = selectedRow.Cells[1].Value.ToString();

            }
            else
            {
                piesaAdaugata.Text = selectedRow.Cells[0].Value.ToString();
                cantitateLbl.Text = "Cantitate: ";
                cantitate.Text = selectedRow.Cells[5].Value.ToString();
            }
            //cantitate.Text = selectedRow.Cells[6].Value.ToString();

            //Aici imi afiseaza cantitatea respectiva dupa ce apasa pe o anumita piesa pentru a o modifica dupa
            // si evit o eroare cand inca nu am intrat intr-o functie si apas pe tabelul respectiv

        skip:;
        }

        private void addPiesaLista()
        {
            //aici adaug o piesa anume intr-o lista anume, dupa ce apas pe lista si pe butonul de adaugare
            // apas apoi pe o piesa si este bagata in lista respectiva
            String query = "INSERT INTO ListaPiese_Piese (piesa_id, lpiesa_id, cant_nec) VALUES('" + idBoxPiesa + "','" + idBoxLista + "','" + int.Parse(cantitate.Text) + "')";
            SqlCommand cmd = new SqlCommand(query, conn);

            if (!String.IsNullOrEmpty(cantitate.Text))
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
        }

        private void delPiesaLista()
        {
            //foarte similar cu adaugarea de piese
            String query = "DELETE FROM ListaPiese_Piese WHERE piesa_id = '" + idBoxPiesa + "'AND lpiesa_id = '" + idBoxLista + "'";
            SqlCommand cmd = new SqlCommand(query, conn);

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



        private void ResetInput()
        {
            piesaAdaugata.Clear();
            cantitate.Clear();
        }

        private void delPiese_Click(object sender, EventArgs e)
        {
            // am aici cele doua stari cu modificare de culoare, care sa ne arate parcursul functiei
            // in prima faza, aleg ce vreau sa fac, este colorat un buton si dupa ce efectuez operatia
            // se schimba iar butonul in culoarea initiala 

            if (contDel == 2)
            {
                EnableButtons(0);
                delPiese.Enabled = true;
                String query = "SELECT * FROM Piese WHERE Piese.piesa_id IN ( SELECT P1.piesa_id FROM Piese P1 INNER JOIN ListaPiese_Piese LPP1 ON P1.piesa_id = LPP1.piesa_id WHERE LPP1.lpiesa_id = '" + idBoxLista + "')";
                LoadPieseGrid(query);
                contDel--;
                delPiese.BackColor = Color.Red;
            }
            else if (contDel == 1)
            {
                delPiesaLista();
                LoadStatisticGrid();
                contDel = 2;
                delPiese.BackColor = DefaultBackColor;
                ResetInput();
                EnableButtons(1);
            }
        }

        private void addLista_Click(object sender, EventArgs e)
        {
            //foarte similar functiei de mai sus

            if (contAddList == 2)
            {
                EnableButtons(0);
                addLista.Enabled = true;
                contAddList--;
                addLista.BackColor = Color.Yellow;
                piesaAdaugata.ReadOnly = false;
                cantitateLbl.Text = "Versiune: ";
            }
            else if (contAddList == 1)
            {
                String query = "INSERT INTO ListaPiese (denumire, versiune) VALUES('" + piesaAdaugata.Text + "','" + int.Parse(cantitate.Text) + "')";
                SqlCommand cmd = new SqlCommand(query, conn);

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
                        LoadLPieseGrid(null);
                        ResetInput();
                    }



                LoadStatisticGrid();
                contAddList = 2;
                addLista.BackColor = DefaultBackColor;
                piesaAdaugata.ReadOnly = true;
                cantitateLbl.Text = "Cantitate: ";
                ResetInput();
                EnableButtons(1);
            }
        }

        private void delLista_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM ListaPiese WHERE lpiese_id = '" + idBoxLista + "'";
            SqlCommand cmd = new SqlCommand(query, conn);

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
                LoadLPieseGrid(null);
                ResetInput();

            }
        }

        private void modificare_Click(object sender, EventArgs e)
        {
            
            if (contModif == 2)
            {
                EnableButtons(0);
                modificare.Enabled = true;
                contModif--;
                modificare.BackColor = Color.Orange;
                piesaAdaugata.ReadOnly = false;
            }
            else if (contModif == 1)
            {
                String query = "UPDATE ListaPiese SET denumire = '" + piesaAdaugata.Text + "',versiune = '" + int.Parse(cantitate.Text) + "'WHERE lpiese_id = '" + idBoxLista+ "'";
                SqlCommand cmd = new SqlCommand(query, conn);

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
                    LoadLPieseGrid(null);
                    ResetInput();
                }



                LoadStatisticGrid();
                contModif = 2;
                modificare.BackColor = DefaultBackColor;
                piesaAdaugata.ReadOnly = true;
                cantitateLbl.Text = "Cantitate: ";
                ResetInput();
                EnableButtons(1);
            }
            
        }

        private void EnableButtons(int state)
        {
            // aici fortez butoanele sa fie toate intr-o anumita stare sau alta pentru a usura blocarea lor
            // vreau sa fie utilizabile doar dupa ce am ales o lista, evident, nu toate
            if (state == 1)
            {
                addPiese.Enabled = true;
                delPiese.Enabled = true;
                addLista.Enabled = true;
                modificare.Enabled = true;
                delLista.Enabled = true;
                modificareCant.Enabled = true;
            }
            else
            {
                addPiese.Enabled = false;
                delPiese.Enabled = false;
                addLista.Enabled = false;
                modificare.Enabled = false;
                delLista.Enabled = false;
                modificareCant.Enabled = false;
            }
        }

        private void modificareCant_Click(object sender, EventArgs e)
        {
            //Foarte similar cu functia de mai sus
            if (contModifCant == 2)
            {
                EnableButtons(0);
                modificareCant.Enabled = true;
                cantitate.Clear();
                cantitateLbl.Text = "Cantitate: ";
                String query = "SELECT * FROM Piese WHERE Piese.piesa_id IN ( SELECT P1.piesa_id FROM Piese P1 INNER JOIN ListaPiese_Piese LPP1 ON P1.piesa_id = LPP1.piesa_id WHERE LPP1.lpiesa_id = '" + idBoxLista + "')";
                LoadPieseGrid(query);
                contModifCant--;
                modificareCant.BackColor = Color.Violet;
            }
            else if (contModifCant == 1)
            {
                updateCantLista();
                LoadStatisticGrid();
                contModifCant = 2;
                modificareCant.BackColor = DefaultBackColor;
                ResetInput();
                EnableButtons(1);
            }
        }

        private void updateCantLista()
        {
            String query = "UPDATE ListaPiese_Piese SET cant_nec = '" + int.Parse(cantitate.Text) + "' WHERE ListaPiese_Piese.piesa_id = '" + idBoxPiesa + "'AND ListaPiese_Piese.lpiesa_id = '" + idBoxLista + "'";
            SqlCommand cmd = new SqlCommand(query, conn);

            if (!String.IsNullOrEmpty(cantitate.Text))
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
        }
    }
}
