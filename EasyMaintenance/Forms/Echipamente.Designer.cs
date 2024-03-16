namespace EasyMaintenance.Forms
{
    partial class Echipamente
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
            this.cod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.denumire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.preventiva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.echipGrid = new System.Windows.Forms.DataGridView();
            this.tip = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.client = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.responsabil = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lista_oper = new System.Windows.Forms.ComboBox();
            this.lista_piese = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.echipGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cod
            // 
            this.cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cod.Location = new System.Drawing.Point(169, 39);
            this.cod.Margin = new System.Windows.Forms.Padding(4);
            this.cod.Name = "cod";
            this.cod.Size = new System.Drawing.Size(132, 27);
            this.cod.TabIndex = 0;
            this.cod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(112, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(64, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Denumire:";
            // 
            // denumire
            // 
            this.denumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.denumire.Location = new System.Drawing.Point(169, 71);
            this.denumire.Margin = new System.Windows.Forms.Padding(4);
            this.denumire.Name = "denumire";
            this.denumire.Size = new System.Drawing.Size(253, 27);
            this.denumire.TabIndex = 2;
            this.denumire.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(119, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(99, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Client:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(16, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lista oper:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(9, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lista piese:";
            // 
            // preventiva
            // 
            this.preventiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.preventiva.Location = new System.Drawing.Point(965, 39);
            this.preventiva.Margin = new System.Windows.Forms.Padding(4);
            this.preventiva.Name = "preventiva";
            this.preventiva.Size = new System.Drawing.Size(232, 27);
            this.preventiva.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(852, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "Preventiva:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(837, 75);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Responsabil:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // echipGrid
            // 
            this.echipGrid.AllowUserToAddRows = false;
            this.echipGrid.AllowUserToDeleteRows = false;
            this.echipGrid.AllowUserToResizeColumns = false;
            this.echipGrid.AllowUserToResizeRows = false;
            this.echipGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.echipGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.echipGrid.Location = new System.Drawing.Point(13, 370);
            this.echipGrid.Margin = new System.Windows.Forms.Padding(4);
            this.echipGrid.Name = "echipGrid";
            this.echipGrid.ReadOnly = true;
            this.echipGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.echipGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.echipGrid.Size = new System.Drawing.Size(1282, 330);
            this.echipGrid.TabIndex = 18;
            // 
            // tip
            // 
            this.tip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tip.FormattingEnabled = true;
            this.tip.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.tip.Location = new System.Drawing.Point(169, 107);
            this.tip.Margin = new System.Windows.Forms.Padding(4);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(186, 28);
            this.tip.TabIndex = 19;
            this.tip.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lista_piese);
            this.panel1.Controls.Add(this.lista_oper);
            this.panel1.Controls.Add(this.client);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(49, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 266);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // client
            // 
            this.client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.client.FormattingEnabled = true;
            this.client.Location = new System.Drawing.Point(119, 115);
            this.client.Margin = new System.Windows.Forms.Padding(4);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(186, 28);
            this.client.TabIndex = 27;
            this.client.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.responsabil);
            this.panel2.Location = new System.Drawing.Point(825, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 266);
            this.panel2.TabIndex = 21;
            // 
            // responsabil
            // 
            this.responsabil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.responsabil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.responsabil.Location = new System.Drawing.Point(139, 47);
            this.responsabil.Name = "responsabil";
            this.responsabil.Size = new System.Drawing.Size(232, 28);
            this.responsabil.TabIndex = 0;
            this.responsabil.SelectedIndexChanged += new System.EventHandler(this.responsabil_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(49, 299);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 64);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(825, 299);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 64);
            this.panel4.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 62);
            this.button1.TabIndex = 23;
            this.button1.Text = "Adaugare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(609, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 62);
            this.button2.TabIndex = 24;
            this.button2.Text = "Modificare";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(609, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 62);
            this.button3.TabIndex = 25;
            this.button3.Text = "Listare";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(609, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 62);
            this.button4.TabIndex = 26;
            this.button4.Text = "Cautare";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lista_oper
            // 
            this.lista_oper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lista_oper.DropDownWidth = 350;
            this.lista_oper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lista_oper.FormattingEnabled = true;
            this.lista_oper.Location = new System.Drawing.Point(119, 152);
            this.lista_oper.Margin = new System.Windows.Forms.Padding(4);
            this.lista_oper.Name = "lista_oper";
            this.lista_oper.Size = new System.Drawing.Size(253, 28);
            this.lista_oper.TabIndex = 28;
            // 
            // lista_piese
            // 
            this.lista_piese.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lista_piese.DropDownWidth = 350;
            this.lista_piese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lista_piese.FormattingEnabled = true;
            this.lista_piese.Location = new System.Drawing.Point(118, 187);
            this.lista_piese.Margin = new System.Windows.Forms.Padding(4);
            this.lista_piese.Name = "lista_piese";
            this.lista_piese.Size = new System.Drawing.Size(254, 28);
            this.lista_piese.TabIndex = 29;
            // 
            // Echipamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 627);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.echipGrid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.preventiva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.denumire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cod);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Echipamente";
            this.Text = "Echipamente";
            this.Load += new System.EventHandler(this.Echipamente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.echipGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox denumire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox preventiva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView echipGrid;
        private System.Windows.Forms.ComboBox tip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox client;
        private System.Windows.Forms.ComboBox responsabil;
        private System.Windows.Forms.ComboBox lista_piese;
        private System.Windows.Forms.ComboBox lista_oper;
    }
}