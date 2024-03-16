namespace EasyMaintenance.Forms
{
    partial class Clienti
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
            this.components = new System.ComponentModel.Container();
            this.clientiGrid = new System.Windows.Forms.DataGridView();
            this.clientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mentenantaDataSet4 = new EasyMaintenance.MentenantaDataSet4();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.denumire = new System.Windows.Forms.TextBox();
            this.strada = new System.Windows.Forms.TextBox();
            this.numar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nrEchip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.oras = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.incepereActivitate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nrTicheteActive = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nrTichete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.modiButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.mentenantaDataSet2 = new EasyMaintenance.MentenantaDataSet2();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new EasyMaintenance.MentenantaDataSet2TableAdapters.ClientTableAdapter();
            this.mentenantaDataSet3 = new EasyMaintenance.MentenantaDataSet3();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter1 = new EasyMaintenance.MentenantaDataSet3TableAdapters.ClientTableAdapter();
            this.clientTableAdapter2 = new EasyMaintenance.MentenantaDataSet4TableAdapters.ClientTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.echiplbl = new System.Windows.Forms.Label();
            this.luna = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lunalbl = new System.Windows.Forms.Label();
            this.echipament = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientiGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentenantaDataSet4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mentenantaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentenantaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientiGrid
            // 
            this.clientiGrid.AllowUserToAddRows = false;
            this.clientiGrid.AllowUserToDeleteRows = false;
            this.clientiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientiGrid.Location = new System.Drawing.Point(737, 15);
            this.clientiGrid.Margin = new System.Windows.Forms.Padding(4);
            this.clientiGrid.Name = "clientiGrid";
            this.clientiGrid.ReadOnly = true;
            this.clientiGrid.RowHeadersWidth = 51;
            this.clientiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientiGrid.Size = new System.Drawing.Size(578, 721);
            this.clientiGrid.TabIndex = 1;
            this.clientiGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientiGrid_CellContentClick);
            // 
            // clientBindingSource2
            // 
            this.clientBindingSource2.DataMember = "Client";
            this.clientBindingSource2.DataSource = this.mentenantaDataSet4;
            // 
            // mentenantaDataSet4
            // 
            this.mentenantaDataSet4.DataSetName = "MentenantaDataSet4";
            this.mentenantaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(66, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Denumire:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(90, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Strada:";
            // 
            // denumire
            // 
            this.denumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.denumire.Location = new System.Drawing.Point(166, 22);
            this.denumire.Margin = new System.Windows.Forms.Padding(4);
            this.denumire.Name = "denumire";
            this.denumire.Size = new System.Drawing.Size(259, 27);
            this.denumire.TabIndex = 2;
            // 
            // strada
            // 
            this.strada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.strada.Location = new System.Drawing.Point(166, 92);
            this.strada.Margin = new System.Windows.Forms.Padding(4);
            this.strada.Name = "strada";
            this.strada.Size = new System.Drawing.Size(227, 27);
            this.strada.TabIndex = 3;
            // 
            // numar
            // 
            this.numar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.numar.Location = new System.Drawing.Point(166, 127);
            this.numar.Margin = new System.Windows.Forms.Padding(4);
            this.numar.Name = "numar";
            this.numar.Size = new System.Drawing.Size(100, 27);
            this.numar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(90, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numar:";
            // 
            // nrEchip
            // 
            this.nrEchip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nrEchip.Location = new System.Drawing.Point(190, 12);
            this.nrEchip.Margin = new System.Windows.Forms.Padding(4);
            this.nrEchip.Name = "nrEchip";
            this.nrEchip.ReadOnly = true;
            this.nrEchip.Size = new System.Drawing.Size(100, 27);
            this.nrEchip.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numar echipamente:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 736);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.numar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.oras);
            this.panel2.Controls.Add(this.denumire);
            this.panel2.Controls.Add(this.strada);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(16, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 689);
            this.panel2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(104, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Oras:";
            // 
            // oras
            // 
            this.oras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.oras.Location = new System.Drawing.Point(166, 57);
            this.oras.Margin = new System.Windows.Forms.Padding(4);
            this.oras.Name = "oras";
            this.oras.Size = new System.Drawing.Size(152, 27);
            this.oras.TabIndex = 36;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 206);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 38);
            this.button5.TabIndex = 35;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.incepereActivitate);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.nrTicheteActive);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.nrTichete);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.nrEchip);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(23, 251);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 414);
            this.panel3.TabIndex = 0;
            // 
            // incepereActivitate
            // 
            this.incepereActivitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.incepereActivitate.Location = new System.Drawing.Point(190, 119);
            this.incepereActivitate.Margin = new System.Windows.Forms.Padding(4);
            this.incepereActivitate.Name = "incepereActivitate";
            this.incepereActivitate.ReadOnly = true;
            this.incepereActivitate.Size = new System.Drawing.Size(223, 27);
            this.incepereActivitate.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(22, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Incepere activitate:";
            // 
            // nrTicheteActive
            // 
            this.nrTicheteActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nrTicheteActive.Location = new System.Drawing.Point(190, 84);
            this.nrTicheteActive.Margin = new System.Windows.Forms.Padding(4);
            this.nrTicheteActive.Name = "nrTicheteActive";
            this.nrTicheteActive.ReadOnly = true;
            this.nrTicheteActive.Size = new System.Drawing.Size(73, 27);
            this.nrTicheteActive.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(107, 51);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tichete:";
            // 
            // nrTichete
            // 
            this.nrTichete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.nrTichete.Location = new System.Drawing.Point(190, 48);
            this.nrTichete.Margin = new System.Windows.Forms.Padding(4);
            this.nrTichete.Name = "nrTichete";
            this.nrTichete.ReadOnly = true;
            this.nrTichete.Size = new System.Drawing.Size(73, 27);
            this.nrTichete.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(55, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tichete active:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(558, 261);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 62);
            this.button4.TabIndex = 34;
            this.button4.Text = "Cautare";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(558, 193);
            this.delButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(124, 62);
            this.delButton.TabIndex = 33;
            this.delButton.Text = "Stergere";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // modiButton
            // 
            this.modiButton.Location = new System.Drawing.Point(558, 126);
            this.modiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modiButton.Name = "modiButton";
            this.modiButton.Size = new System.Drawing.Size(124, 62);
            this.modiButton.TabIndex = 32;
            this.modiButton.Text = "Modificare";
            this.modiButton.UseVisualStyleBackColor = true;
            this.modiButton.Click += new System.EventHandler(this.modiButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(558, 57);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(124, 62);
            this.addButton.TabIndex = 31;
            this.addButton.Text = "Adaugare";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // mentenantaDataSet2
            // 
            this.mentenantaDataSet2.DataSetName = "MentenantaDataSet2";
            this.mentenantaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.mentenantaDataSet2;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // mentenantaDataSet3
            // 
            this.mentenantaDataSet3.DataSetName = "MentenantaDataSet3";
            this.mentenantaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "Client";
            this.clientBindingSource1.DataSource = this.mentenantaDataSet3;
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // clientTableAdapter2
            // 
            this.clientTableAdapter2.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label9.Location = new System.Drawing.Point(63, 184);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(299, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Urmatoarea activitate pe anul curent";
            // 
            // echiplbl
            // 
            this.echiplbl.AutoSize = true;
            this.echiplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.echiplbl.Location = new System.Drawing.Point(7, 58);
            this.echiplbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.echiplbl.Name = "echiplbl";
            this.echiplbl.Size = new System.Drawing.Size(109, 22);
            this.echiplbl.TabIndex = 16;
            this.echiplbl.Text = "Echipament:";
            // 
            // luna
            // 
            this.luna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.luna.Location = new System.Drawing.Point(124, 20);
            this.luna.Margin = new System.Windows.Forms.Padding(4);
            this.luna.Name = "luna";
            this.luna.ReadOnly = true;
            this.luna.Size = new System.Drawing.Size(258, 27);
            this.luna.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.echipament);
            this.panel4.Controls.Add(this.lunalbl);
            this.panel4.Controls.Add(this.luna);
            this.panel4.Controls.Add(this.echiplbl);
            this.panel4.Location = new System.Drawing.Point(18, 209);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 186);
            this.panel4.TabIndex = 18;
            // 
            // lunalbl
            // 
            this.lunalbl.AutoSize = true;
            this.lunalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lunalbl.Location = new System.Drawing.Point(61, 23);
            this.lunalbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lunalbl.Name = "lunalbl";
            this.lunalbl.Size = new System.Drawing.Size(55, 22);
            this.lunalbl.TabIndex = 18;
            this.lunalbl.Text = "Luna:";
            // 
            // echipament
            // 
            this.echipament.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.echipament.Location = new System.Drawing.Point(123, 55);
            this.echipament.Margin = new System.Windows.Forms.Padding(4);
            this.echipament.Multiline = true;
            this.echipament.Name = "echipament";
            this.echipament.ReadOnly = true;
            this.echipament.Size = new System.Drawing.Size(259, 112);
            this.echipament.TabIndex = 19;
            // 
            // Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 736);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.modiButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.clientiGrid);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Clienti";
            this.Text = "Clienti";
            this.Load += new System.EventHandler(this.Clienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientiGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentenantaDataSet4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mentenantaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentenantaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView clientiGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox denumire;
        private System.Windows.Forms.TextBox strada;
        private System.Windows.Forms.TextBox numar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nrEchip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox nrTichete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nrTicheteActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button modiButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button5;
        private MentenantaDataSet2 mentenantaDataSet2;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private MentenantaDataSet2TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox oras;
        private MentenantaDataSet3 mentenantaDataSet3;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private MentenantaDataSet3TableAdapters.ClientTableAdapter clientTableAdapter1;
        private MentenantaDataSet4 mentenantaDataSet4;
        private System.Windows.Forms.BindingSource clientBindingSource2;
        private MentenantaDataSet4TableAdapters.ClientTableAdapter clientTableAdapter2;
        private System.Windows.Forms.TextBox incepereActivitate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox luna;
        private System.Windows.Forms.Label echiplbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox echipament;
        private System.Windows.Forms.Label lunalbl;
    }
}