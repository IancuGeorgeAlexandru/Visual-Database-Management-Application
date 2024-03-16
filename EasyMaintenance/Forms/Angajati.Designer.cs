namespace EasyMaintenance.Forms
{
    partial class Angajati
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.angajatiGrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.nivel_acc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.primulClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.incepereActivitate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nrEchip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.modiButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.opPref = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nrAplic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.angajatiGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // angajatiGrid
            // 
            this.angajatiGrid.AllowUserToAddRows = false;
            this.angajatiGrid.AllowUserToDeleteRows = false;
            this.angajatiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.angajatiGrid.Location = new System.Drawing.Point(12, 171);
            this.angajatiGrid.Name = "angajatiGrid";
            this.angajatiGrid.ReadOnly = true;
            this.angajatiGrid.RowHeadersWidth = 51;
            this.angajatiGrid.RowTemplate.Height = 24;
            this.angajatiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.angajatiGrid.Size = new System.Drawing.Size(333, 525);
            this.angajatiGrid.TabIndex = 5;
            this.angajatiGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.angajatiGrid_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(32, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "username:";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.username.Location = new System.Drawing.Point(132, 15);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(159, 27);
            this.username.TabIndex = 18;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // nivel_acc
            // 
            this.nivel_acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nivel_acc.Location = new System.Drawing.Point(132, 48);
            this.nivel_acc.Name = "nivel_acc";
            this.nivel_acc.Size = new System.Drawing.Size(159, 27);
            this.nivel_acc.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.Location = new System.Drawing.Point(21, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "nivel acces:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.nivel_acc);
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 153);
            this.panel2.TabIndex = 35;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 109);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 38);
            this.button5.TabIndex = 41;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.primulClient);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.incepereActivitate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.nrEchip);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(513, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 130);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // primulClient
            // 
            this.primulClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.primulClient.Location = new System.Drawing.Point(192, 86);
            this.primulClient.Margin = new System.Windows.Forms.Padding(4);
            this.primulClient.Name = "primulClient";
            this.primulClient.ReadOnly = true;
            this.primulClient.Size = new System.Drawing.Size(223, 27);
            this.primulClient.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(72, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "Primul client:";
            // 
            // incepereActivitate
            // 
            this.incepereActivitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.incepereActivitate.Location = new System.Drawing.Point(192, 51);
            this.incepereActivitate.Margin = new System.Windows.Forms.Padding(4);
            this.incepereActivitate.Name = "incepereActivitate";
            this.incepereActivitate.ReadOnly = true;
            this.incepereActivitate.Size = new System.Drawing.Size(223, 27);
            this.incepereActivitate.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(24, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 22);
            this.label7.TabIndex = 47;
            this.label7.Text = "Incepere activitate:";
            // 
            // nrEchip
            // 
            this.nrEchip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nrEchip.Location = new System.Drawing.Point(257, 15);
            this.nrEchip.Margin = new System.Windows.Forms.Padding(4);
            this.nrEchip.Name = "nrEchip";
            this.nrEchip.ReadOnly = true;
            this.nrEchip.Size = new System.Drawing.Size(158, 27);
            this.nrEchip.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Echipamente in mentenanta: ";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(361, 215);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 62);
            this.button4.TabIndex = 40;
            this.button4.Text = "Cautare";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(361, 147);
            this.delButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(124, 62);
            this.delButton.TabIndex = 39;
            this.delButton.Text = "Stergere";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // modiButton
            // 
            this.modiButton.Location = new System.Drawing.Point(361, 80);
            this.modiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modiButton.Name = "modiButton";
            this.modiButton.Size = new System.Drawing.Size(124, 62);
            this.modiButton.TabIndex = 38;
            this.modiButton.Text = "Modificare";
            this.modiButton.UseVisualStyleBackColor = true;
            this.modiButton.Click += new System.EventHandler(this.modiButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(361, 11);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(124, 62);
            this.addButton.TabIndex = 37;
            this.addButton.Text = "Adaugare";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.nrAplic);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.opPref);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(513, 178);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 174);
            this.panel3.TabIndex = 41;
            // 
            // opPref
            // 
            this.opPref.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.opPref.Location = new System.Drawing.Point(123, 15);
            this.opPref.Margin = new System.Windows.Forms.Padding(4);
            this.opPref.Multiline = true;
            this.opPref.Name = "opPref";
            this.opPref.ReadOnly = true;
            this.opPref.Size = new System.Drawing.Size(292, 112);
            this.opPref.TabIndex = 51;
            this.opPref.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(23, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 53;
            this.label5.Text = "Denumire:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 54;
            this.label3.Text = "Numar aplicari:";
            // 
            // nrAplic
            // 
            this.nrAplic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nrAplic.Location = new System.Drawing.Point(161, 135);
            this.nrAplic.Margin = new System.Windows.Forms.Padding(4);
            this.nrAplic.Name = "nrAplic";
            this.nrAplic.ReadOnly = true;
            this.nrAplic.Size = new System.Drawing.Size(105, 27);
            this.nrAplic.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(522, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 42;
            this.label4.Text = "Operatii preferate";
            // 
            // Angajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 739);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.modiButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.angajatiGrid);
            this.Name = "Angajati";
            this.Text = "Angajati";
            this.Load += new System.EventHandler(this.Angajati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.angajatiGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView angajatiGrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox nivel_acc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button modiButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nrEchip;
        private System.Windows.Forms.TextBox incepereActivitate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox primulClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox opPref;
        private System.Windows.Forms.TextBox nrAplic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}