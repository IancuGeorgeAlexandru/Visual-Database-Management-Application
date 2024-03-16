namespace EasyMaintenance.Forms
{
    partial class Operatii
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
            this.button1 = new System.Windows.Forms.Button();
            this.opGrid = new System.Windows.Forms.DataGridView();
            this.operatieidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.denumireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructiuneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sculespecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicprevDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.apliccorectDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.durataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mentenantaDataSet1 = new EasyMaintenance.MentenantaDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.denumire = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.durata = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.aplic_corect = new System.Windows.Forms.CheckBox();
            this.aplic_prev = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scule_spec = new System.Windows.Forms.TextBox();
            this.instruct = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delButton = new System.Windows.Forms.Button();
            this.modiButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.operatieTableAdapter = new EasyMaintenance.MentenantaDataSet1TableAdapters.OperatieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.opGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentenantaDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 293);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // opGrid
            // 
            this.opGrid.AllowUserToAddRows = false;
            this.opGrid.AllowUserToDeleteRows = false;
            this.opGrid.AutoGenerateColumns = false;
            this.opGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.opGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operatieidDataGridViewTextBoxColumn,
            this.denumireDataGridViewTextBoxColumn,
            this.instructiuneDataGridViewTextBoxColumn,
            this.sculespecDataGridViewTextBoxColumn,
            this.aplicprevDataGridViewCheckBoxColumn,
            this.apliccorectDataGridViewCheckBoxColumn,
            this.durataDataGridViewTextBoxColumn});
            this.opGrid.DataSource = this.operatieBindingSource;
            this.opGrid.Location = new System.Drawing.Point(676, 26);
            this.opGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.opGrid.Name = "opGrid";
            this.opGrid.ReadOnly = true;
            this.opGrid.RowHeadersWidth = 51;
            this.opGrid.RowTemplate.Height = 24;
            this.opGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.opGrid.Size = new System.Drawing.Size(768, 652);
            this.opGrid.TabIndex = 38;
            this.opGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // operatieidDataGridViewTextBoxColumn
            // 
            this.operatieidDataGridViewTextBoxColumn.DataPropertyName = "operatie_id";
            this.operatieidDataGridViewTextBoxColumn.HeaderText = "operatie_id";
            this.operatieidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operatieidDataGridViewTextBoxColumn.Name = "operatieidDataGridViewTextBoxColumn";
            this.operatieidDataGridViewTextBoxColumn.ReadOnly = true;
            this.operatieidDataGridViewTextBoxColumn.Width = 70;
            // 
            // denumireDataGridViewTextBoxColumn
            // 
            this.denumireDataGridViewTextBoxColumn.DataPropertyName = "denumire";
            this.denumireDataGridViewTextBoxColumn.HeaderText = "denumire";
            this.denumireDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.denumireDataGridViewTextBoxColumn.Name = "denumireDataGridViewTextBoxColumn";
            this.denumireDataGridViewTextBoxColumn.ReadOnly = true;
            this.denumireDataGridViewTextBoxColumn.Width = 150;
            // 
            // instructiuneDataGridViewTextBoxColumn
            // 
            this.instructiuneDataGridViewTextBoxColumn.DataPropertyName = "instructiune";
            this.instructiuneDataGridViewTextBoxColumn.HeaderText = "instructiune";
            this.instructiuneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instructiuneDataGridViewTextBoxColumn.Name = "instructiuneDataGridViewTextBoxColumn";
            this.instructiuneDataGridViewTextBoxColumn.ReadOnly = true;
            this.instructiuneDataGridViewTextBoxColumn.Width = 125;
            // 
            // sculespecDataGridViewTextBoxColumn
            // 
            this.sculespecDataGridViewTextBoxColumn.DataPropertyName = "scule_spec";
            this.sculespecDataGridViewTextBoxColumn.HeaderText = "scule_spec";
            this.sculespecDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sculespecDataGridViewTextBoxColumn.Name = "sculespecDataGridViewTextBoxColumn";
            this.sculespecDataGridViewTextBoxColumn.ReadOnly = true;
            this.sculespecDataGridViewTextBoxColumn.Width = 125;
            // 
            // aplicprevDataGridViewCheckBoxColumn
            // 
            this.aplicprevDataGridViewCheckBoxColumn.DataPropertyName = "aplic_prev";
            this.aplicprevDataGridViewCheckBoxColumn.HeaderText = "aplic_prev";
            this.aplicprevDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.aplicprevDataGridViewCheckBoxColumn.Name = "aplicprevDataGridViewCheckBoxColumn";
            this.aplicprevDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aplicprevDataGridViewCheckBoxColumn.Width = 60;
            // 
            // apliccorectDataGridViewCheckBoxColumn
            // 
            this.apliccorectDataGridViewCheckBoxColumn.DataPropertyName = "aplic_corect";
            this.apliccorectDataGridViewCheckBoxColumn.HeaderText = "aplic_corect";
            this.apliccorectDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.apliccorectDataGridViewCheckBoxColumn.Name = "apliccorectDataGridViewCheckBoxColumn";
            this.apliccorectDataGridViewCheckBoxColumn.ReadOnly = true;
            this.apliccorectDataGridViewCheckBoxColumn.Width = 125;
            // 
            // durataDataGridViewTextBoxColumn
            // 
            this.durataDataGridViewTextBoxColumn.DataPropertyName = "durata";
            this.durataDataGridViewTextBoxColumn.HeaderText = "durata";
            this.durataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durataDataGridViewTextBoxColumn.Name = "durataDataGridViewTextBoxColumn";
            this.durataDataGridViewTextBoxColumn.ReadOnly = true;
            this.durataDataGridViewTextBoxColumn.Width = 125;
            // 
            // operatieBindingSource
            // 
            this.operatieBindingSource.DataMember = "Operatie";
            this.operatieBindingSource.DataSource = this.mentenantaDataSet1;
            // 
            // mentenantaDataSet1
            // 
            this.mentenantaDataSet1.DataSetName = "MentenantaDataSet1";
            this.mentenantaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(48, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Denumire:";
            // 
            // denumire
            // 
            this.denumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.denumire.Location = new System.Drawing.Point(153, 15);
            this.denumire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.denumire.Name = "denumire";
            this.denumire.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.denumire.Size = new System.Drawing.Size(253, 27);
            this.denumire.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.durata);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.aplic_corect);
            this.panel1.Controls.Add(this.aplic_prev);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.scule_spec);
            this.panel1.Controls.Add(this.instruct);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.denumire);
            this.panel1.Location = new System.Drawing.Point(29, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 340);
            this.panel1.TabIndex = 45;
            // 
            // durata
            // 
            this.durata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.durata.Location = new System.Drawing.Point(153, 212);
            this.durata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.durata.Name = "durata";
            this.durata.Size = new System.Drawing.Size(253, 27);
            this.durata.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(72, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "Durata:";
            // 
            // aplic_corect
            // 
            this.aplic_corect.AutoSize = true;
            this.aplic_corect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.aplic_corect.Location = new System.Drawing.Point(243, 171);
            this.aplic_corect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aplic_corect.Name = "aplic_corect";
            this.aplic_corect.Size = new System.Drawing.Size(168, 24);
            this.aplic_corect.TabIndex = 47;
            this.aplic_corect.Text = "Aplicatie corectiva";
            this.aplic_corect.UseVisualStyleBackColor = true;
            // 
            // aplic_prev
            // 
            this.aplic_prev.AutoSize = true;
            this.aplic_prev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.aplic_prev.Location = new System.Drawing.Point(35, 171);
            this.aplic_prev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aplic_prev.Name = "aplic_prev";
            this.aplic_prev.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aplic_prev.Size = new System.Drawing.Size(176, 24);
            this.aplic_prev.TabIndex = 46;
            this.aplic_prev.Text = "Aplicatie preventiva";
            this.aplic_prev.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(8, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "Scule speciale:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 44;
            this.label1.Text = "Instructiune:";
            // 
            // scule_spec
            // 
            this.scule_spec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.scule_spec.Location = new System.Drawing.Point(153, 114);
            this.scule_spec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scule_spec.Name = "scule_spec";
            this.scule_spec.Size = new System.Drawing.Size(253, 27);
            this.scule_spec.TabIndex = 42;
            // 
            // instruct
            // 
            this.instruct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.instruct.Location = new System.Drawing.Point(153, 50);
            this.instruct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.instruct.Name = "instruct";
            this.instruct.Size = new System.Drawing.Size(253, 27);
            this.instruct.TabIndex = 41;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(524, 230);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 62);
            this.button4.TabIndex = 44;
            this.button4.Text = "Cautare";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(29, 372);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 306);
            this.panel2.TabIndex = 47;
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(524, 162);
            this.delButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(124, 62);
            this.delButton.TabIndex = 43;
            this.delButton.Text = "Stergere";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // modiButton
            // 
            this.modiButton.Location = new System.Drawing.Point(524, 94);
            this.modiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modiButton.Name = "modiButton";
            this.modiButton.Size = new System.Drawing.Size(124, 62);
            this.modiButton.TabIndex = 42;
            this.modiButton.Text = "Modificare";
            this.modiButton.UseVisualStyleBackColor = true;
            this.modiButton.Click += new System.EventHandler(this.modiButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(524, 26);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(124, 62);
            this.addButton.TabIndex = 41;
            this.addButton.Text = "Adaugare";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // operatieTableAdapter
            // 
            this.operatieTableAdapter.ClearBeforeFill = true;
            // 
            // Operatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 698);
            this.Controls.Add(this.opGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.modiButton);
            this.Controls.Add(this.addButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Operatii";
            this.Text = "Operatii";
            this.Load += new System.EventHandler(this.Operatii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentenantaDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView opGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox denumire;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button modiButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox scule_spec;
        private System.Windows.Forms.TextBox instruct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox aplic_prev;
        private System.Windows.Forms.TextBox durata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox aplic_corect;
        private MentenantaDataSet1 mentenantaDataSet1;
        private System.Windows.Forms.BindingSource operatieBindingSource;
        private MentenantaDataSet1TableAdapters.OperatieTableAdapter operatieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatieidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn denumireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instructiuneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sculespecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aplicprevDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn apliccorectDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durataDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}