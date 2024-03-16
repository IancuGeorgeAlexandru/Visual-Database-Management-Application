using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyMaintenance.Forms
{
    public partial class Mentenanta : Form
    {
        // Aici am un meniu cu mai multe butoane care au o actiune specific, adica odata apasate, se maresc si restul rama
        // la o dimensiune standard
        private Button currentButton;
        private Button nextButton;
        private Form activeForm;

        // Am incercat si o schimbare a temei dupa mai multe culori, dupa culoare principala si secundara
        private Color mainColor = Color.LightSteelBlue;
        private Color accentColor = Color.LightSlateGray;

        public Mentenanta()
        {
            InitializeComponent();
           
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DeactivateButton();
                    Color color = accentColor;
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        private void DeactivateButton()
        {
            foreach (Control previousBtn in panelMenu_Mentenanta.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = mainColor;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        private void Mentenanta_Load(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.smallPanel.Controls.Add(childForm);
            this.smallPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void smallPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //Fiecare buton imi deschide un anumit Form copil in interiorul sau

      

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Piese(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Lista_piese(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Operatii(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Lista_operatii(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Echipamente(), sender);
        }
    }
}
