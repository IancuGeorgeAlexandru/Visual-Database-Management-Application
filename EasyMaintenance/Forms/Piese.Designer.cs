namespace EasyMaintenance.Forms
{
    partial class Piese
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.poz_raft = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.denumire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cod_sap = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cant = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.modiButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.pieseGrid = new System.Windows.Forms.DataGridView();
            this.pieseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mentenantaDataSet = new EasyMaintenance.MentenantaDataSet();
            this.pieseTableAdapter = new EasyMaintenance.MentenantaDataSetTableAdapters.PieseTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentenantaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(45, 306);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 64);
            this.panel3.TabIndex = 37;
            // 
            // poz_raft
            // 
            this.poz_raft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.poz_raft.Location = new System.Drawing.Point(120, 82);
            this.poz_raft.Margin = new System.Windows.Forms.Padding(4);
            this.poz_raft.Name = "poz_raft";
            this.poz_raft.Size = new System.Drawing.Size(253, 27);
            this.poz_raft.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(11, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Pozitie raft:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "Denumire:";
            // 
            // denumire
            // 
            this.denumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.denumire.Location = new System.Drawing.Point(120, 47);
            this.denumire.Margin = new System.Windows.Forms.Padding(4);
            this.denumire.Name = "denumire";
            this.denumire.Size = new System.Drawing.Size(253, 27);
            this.denumire.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "Cod SAP:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cod_sap
            // 
            this.cod_sap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cod_sap.Location = new System.Drawing.Point(120, 11);
            this.cod_sap.Margin = new System.Windows.Forms.Padding(4);
            this.cod_sap.Name = "cod_sap";
            this.cod_sap.Size = new System.Drawing.Size(132, 27);
            this.cod_sap.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cost);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cant);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.poz_raft);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cod_sap);
            this.panel1.Controls.Add(this.denumire);
            this.panel1.Location = new System.Drawing.Point(45, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 270);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(4, 226);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 38);
            this.button5.TabIndex = 31;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(25, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cantitate:";
            // 
            // cant
            // 
            this.cant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cant.Location = new System.Drawing.Point(120, 118);
            this.cant.Margin = new System.Windows.Forms.Padding(4);
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(132, 27);
            this.cant.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(45, 377);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 306);
            this.panel2.TabIndex = 37;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(541, 234);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 62);
            this.button4.TabIndex = 30;
            this.button4.Text = "Cautare";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(541, 166);
            this.delButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(124, 62);
            this.delButton.TabIndex = 29;
            this.delButton.Text = "Stergere";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // modiButton
            // 
            this.modiButton.Location = new System.Drawing.Point(541, 98);
            this.modiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modiButton.Name = "modiButton";
            this.modiButton.Size = new System.Drawing.Size(124, 62);
            this.modiButton.TabIndex = 28;
            this.modiButton.Text = "Modificare";
            this.modiButton.UseVisualStyleBackColor = true;
            this.modiButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(541, 30);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(124, 62);
            this.addButton.TabIndex = 27;
            this.addButton.Text = "Adaugare";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pieseGrid
            // 
            this.pieseGrid.AllowUserToAddRows = false;
            this.pieseGrid.AllowUserToDeleteRows = false;
            this.pieseGrid.AllowUserToResizeColumns = false;
            this.pieseGrid.AllowUserToResizeRows = false;
            this.pieseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pieseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pieseGrid.Location = new System.Drawing.Point(699, 30);
            this.pieseGrid.Margin = new System.Windows.Forms.Padding(4);
            this.pieseGrid.Name = "pieseGrid";
            this.pieseGrid.ReadOnly = true;
            this.pieseGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.pieseGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pieseGrid.Size = new System.Drawing.Size(568, 654);
            this.pieseGrid.TabIndex = 38;
            this.pieseGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pieseGrid_CellContentClick_2);
            // 
            // pieseBindingSource
            // 
            this.pieseBindingSource.DataMember = "Piese";
            this.pieseBindingSource.DataSource = this.mentenantaDataSet;
            // 
            // mentenantaDataSet
            // 
            this.mentenantaDataSet.DataSetName = "MentenantaDataSet";
            this.mentenantaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pieseTableAdapter
            // 
            this.pieseTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(60, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Cost:";
            // 
            // cost
            // 
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cost.Location = new System.Drawing.Point(120, 153);
            this.cost.Margin = new System.Windows.Forms.Padding(4);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(96, 27);
            this.cost.TabIndex = 33;
            // 
            // Piese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 737);
            this.Controls.Add(this.pieseGrid);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.modiButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Piese";
            this.Text = "Piese";
            this.Load += new System.EventHandler(this.Piese_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentenantaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox poz_raft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox denumire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cod_sap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button modiButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox cant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView pieseGrid;
        private MentenantaDataSet mentenantaDataSet;
        private System.Windows.Forms.BindingSource pieseBindingSource;
        private MentenantaDataSetTableAdapters.PieseTableAdapter pieseTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label label5;
    }
}