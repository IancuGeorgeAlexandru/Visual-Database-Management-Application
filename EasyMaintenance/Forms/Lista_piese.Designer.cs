namespace EasyMaintenance.Forms
{
    partial class Lista_piese
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
            this.lPieseGrid = new System.Windows.Forms.DataGridView();
            this.listaPieseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaPiese = new EasyMaintenance.ListaPiese();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addPiese = new System.Windows.Forms.Button();
            this.addLista = new System.Windows.Forms.Button();
            this.delPiese = new System.Windows.Forms.Button();
            this.listaPieseTableAdapter = new EasyMaintenance.ListaPieseTableAdapters.ListaPieseTableAdapter();
            this.pieseGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pretLista = new System.Windows.Forms.TextBox();
            this.pretMaxim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pretMediu = new System.Windows.Forms.TextBox();
            this.piesaAdaugataLbl = new System.Windows.Forms.Label();
            this.piesaAdaugata = new System.Windows.Forms.TextBox();
            this.cantitateLbl = new System.Windows.Forms.Label();
            this.cantitate = new System.Windows.Forms.TextBox();
            this.delLista = new System.Windows.Forms.Button();
            this.modificare = new System.Windows.Forms.Button();
            this.modificareCant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lPieseGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPieseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPiese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lPieseGrid
            // 
            this.lPieseGrid.AllowUserToAddRows = false;
            this.lPieseGrid.AllowUserToDeleteRows = false;
            this.lPieseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lPieseGrid.Location = new System.Drawing.Point(12, 47);
            this.lPieseGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lPieseGrid.Name = "lPieseGrid";
            this.lPieseGrid.ReadOnly = true;
            this.lPieseGrid.RowHeadersWidth = 51;
            this.lPieseGrid.RowTemplate.Height = 24;
            this.lPieseGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lPieseGrid.Size = new System.Drawing.Size(557, 498);
            this.lPieseGrid.TabIndex = 0;
            this.lPieseGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // listaPieseBindingSource
            // 
            this.listaPieseBindingSource.DataMember = "ListaPiese";
            this.listaPieseBindingSource.DataSource = this.listaPiese;
            // 
            // listaPiese
            // 
            this.listaPiese.DataSetName = "ListaPiese";
            this.listaPiese.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste piese:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(634, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Piese:";
            // 
            // addPiese
            // 
            this.addPiese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.addPiese.Location = new System.Drawing.Point(12, 553);
            this.addPiese.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPiese.Name = "addPiese";
            this.addPiese.Size = new System.Drawing.Size(181, 62);
            this.addPiese.TabIndex = 4;
            this.addPiese.Text = "Adaugare piese";
            this.addPiese.UseVisualStyleBackColor = true;
            this.addPiese.Click += new System.EventHandler(this.button1_Click);
            // 
            // addLista
            // 
            this.addLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.addLista.Location = new System.Drawing.Point(388, 553);
            this.addLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addLista.Name = "addLista";
            this.addLista.Size = new System.Drawing.Size(181, 62);
            this.addLista.TabIndex = 5;
            this.addLista.Text = "Adaugare lista";
            this.addLista.UseVisualStyleBackColor = true;
            this.addLista.Click += new System.EventHandler(this.addLista_Click);
            // 
            // delPiese
            // 
            this.delPiese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.delPiese.Location = new System.Drawing.Point(199, 553);
            this.delPiese.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delPiese.Name = "delPiese";
            this.delPiese.Size = new System.Drawing.Size(181, 62);
            this.delPiese.TabIndex = 6;
            this.delPiese.Text = "Eliminare piese";
            this.delPiese.UseVisualStyleBackColor = true;
            this.delPiese.Click += new System.EventHandler(this.delPiese_Click);
            // 
            // listaPieseTableAdapter
            // 
            this.listaPieseTableAdapter.ClearBeforeFill = true;
            // 
            // pieseGrid
            // 
            this.pieseGrid.AllowUserToAddRows = false;
            this.pieseGrid.AllowUserToDeleteRows = false;
            this.pieseGrid.AllowUserToResizeColumns = false;
            this.pieseGrid.AllowUserToResizeRows = false;
            this.pieseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pieseGrid.Location = new System.Drawing.Point(638, 47);
            this.pieseGrid.Margin = new System.Windows.Forms.Padding(4);
            this.pieseGrid.Name = "pieseGrid";
            this.pieseGrid.ReadOnly = true;
            this.pieseGrid.RowHeadersWidth = 51;
            this.pieseGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pieseGrid.Size = new System.Drawing.Size(631, 498);
            this.pieseGrid.TabIndex = 39;
            this.pieseGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pieseGrid_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(639, 556);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 40;
            this.label4.Text = "Pret total lista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(659, 591);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 41;
            this.label3.Text = "Pret maxim:";
            // 
            // pretLista
            // 
            this.pretLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.pretLista.Location = new System.Drawing.Point(771, 553);
            this.pretLista.Margin = new System.Windows.Forms.Padding(4);
            this.pretLista.Name = "pretLista";
            this.pretLista.ReadOnly = true;
            this.pretLista.Size = new System.Drawing.Size(138, 27);
            this.pretLista.TabIndex = 42;
            this.pretLista.Text = "\r\n";
            // 
            // pretMaxim
            // 
            this.pretMaxim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.pretMaxim.Location = new System.Drawing.Point(771, 588);
            this.pretMaxim.Margin = new System.Windows.Forms.Padding(4);
            this.pretMaxim.Name = "pretMaxim";
            this.pretMaxim.ReadOnly = true;
            this.pretMaxim.Size = new System.Drawing.Size(83, 27);
            this.pretMaxim.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(662, 626);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Pret mediu:";
            // 
            // pretMediu
            // 
            this.pretMediu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.pretMediu.Location = new System.Drawing.Point(771, 623);
            this.pretMediu.Margin = new System.Windows.Forms.Padding(4);
            this.pretMediu.Name = "pretMediu";
            this.pretMediu.ReadOnly = true;
            this.pretMediu.Size = new System.Drawing.Size(105, 27);
            this.pretMediu.TabIndex = 45;
            // 
            // piesaAdaugataLbl
            // 
            this.piesaAdaugataLbl.AutoSize = true;
            this.piesaAdaugataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.piesaAdaugataLbl.Location = new System.Drawing.Point(928, 556);
            this.piesaAdaugataLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.piesaAdaugataLbl.Name = "piesaAdaugataLbl";
            this.piesaAdaugataLbl.Size = new System.Drawing.Size(86, 22);
            this.piesaAdaugataLbl.TabIndex = 46;
            this.piesaAdaugataLbl.Text = "Adaugati:";
            // 
            // piesaAdaugata
            // 
            this.piesaAdaugata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.piesaAdaugata.Location = new System.Drawing.Point(1022, 551);
            this.piesaAdaugata.Margin = new System.Windows.Forms.Padding(4);
            this.piesaAdaugata.Multiline = true;
            this.piesaAdaugata.Name = "piesaAdaugata";
            this.piesaAdaugata.ReadOnly = true;
            this.piesaAdaugata.Size = new System.Drawing.Size(247, 62);
            this.piesaAdaugata.TabIndex = 47;
            this.piesaAdaugata.Text = "\r\n";
            // 
            // cantitateLbl
            // 
            this.cantitateLbl.AutoSize = true;
            this.cantitateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cantitateLbl.Location = new System.Drawing.Point(928, 624);
            this.cantitateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cantitateLbl.Name = "cantitateLbl";
            this.cantitateLbl.Size = new System.Drawing.Size(87, 22);
            this.cantitateLbl.TabIndex = 48;
            this.cantitateLbl.Text = "Cantitate:";
            // 
            // cantitate
            // 
            this.cantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cantitate.Location = new System.Drawing.Point(1022, 621);
            this.cantitate.Name = "cantitate";
            this.cantitate.Size = new System.Drawing.Size(247, 27);
            this.cantitate.TabIndex = 49;
            // 
            // delLista
            // 
            this.delLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.delLista.Location = new System.Drawing.Point(199, 619);
            this.delLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delLista.Name = "delLista";
            this.delLista.Size = new System.Drawing.Size(181, 62);
            this.delLista.TabIndex = 50;
            this.delLista.Text = "Eliminare lista";
            this.delLista.UseVisualStyleBackColor = true;
            this.delLista.Click += new System.EventHandler(this.delLista_Click);
            // 
            // modificare
            // 
            this.modificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.modificare.Location = new System.Drawing.Point(12, 619);
            this.modificare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificare.Name = "modificare";
            this.modificare.Size = new System.Drawing.Size(181, 62);
            this.modificare.TabIndex = 51;
            this.modificare.Text = "Modificare lista";
            this.modificare.UseVisualStyleBackColor = true;
            this.modificare.Click += new System.EventHandler(this.modificare_Click);
            // 
            // modificareCant
            // 
            this.modificareCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.modificareCant.Location = new System.Drawing.Point(386, 619);
            this.modificareCant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificareCant.Name = "modificareCant";
            this.modificareCant.Size = new System.Drawing.Size(181, 62);
            this.modificareCant.TabIndex = 52;
            this.modificareCant.Text = "Modificare cantitate";
            this.modificareCant.UseVisualStyleBackColor = true;
            this.modificareCant.Click += new System.EventHandler(this.modificareCant_Click);
            // 
            // Lista_piese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 698);
            this.Controls.Add(this.modificareCant);
            this.Controls.Add(this.modificare);
            this.Controls.Add(this.delLista);
            this.Controls.Add(this.cantitate);
            this.Controls.Add(this.cantitateLbl);
            this.Controls.Add(this.piesaAdaugata);
            this.Controls.Add(this.piesaAdaugataLbl);
            this.Controls.Add(this.pretMediu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pretMaxim);
            this.Controls.Add(this.pretLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pieseGrid);
            this.Controls.Add(this.delPiese);
            this.Controls.Add(this.addLista);
            this.Controls.Add(this.addPiese);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPieseGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lista_piese";
            this.Text = "Lista_piese";
            this.Load += new System.EventHandler(this.Lista_piese_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lPieseGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPieseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPiese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lPieseGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addPiese;
        private System.Windows.Forms.Button addLista;
        private System.Windows.Forms.Button delPiese;
        private ListaPiese listaPiese;
        private System.Windows.Forms.BindingSource listaPieseBindingSource;
        private ListaPieseTableAdapters.ListaPieseTableAdapter listaPieseTableAdapter;
        private System.Windows.Forms.DataGridView pieseGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pretLista;
        private System.Windows.Forms.TextBox pretMaxim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pretMediu;
        private System.Windows.Forms.Label piesaAdaugataLbl;
        private System.Windows.Forms.TextBox piesaAdaugata;
        private System.Windows.Forms.Label cantitateLbl;
        private System.Windows.Forms.TextBox cantitate;
        private System.Windows.Forms.Button delLista;
        private System.Windows.Forms.Button modificare;
        private System.Windows.Forms.Button modificareCant;
    }
}