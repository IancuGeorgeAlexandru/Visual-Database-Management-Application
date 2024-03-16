namespace EasyMaintenance.Forms
{
    partial class Lista_operatii
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
            this.delOperatii = new System.Windows.Forms.Button();
            this.addLista = new System.Windows.Forms.Button();
            this.addOperatii = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.operatiiGrid = new System.Windows.Forms.DataGridView();
            this.lOperatiiGrid = new System.Windows.Forms.DataGridView();
            this.durataMaxim = new System.Windows.Forms.TextBox();
            this.durataLista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.operatiiGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOperatiiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // delOperatii
            // 
            this.delOperatii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.delOperatii.Location = new System.Drawing.Point(205, 586);
            this.delOperatii.Name = "delOperatii";
            this.delOperatii.Size = new System.Drawing.Size(181, 61);
            this.delOperatii.TabIndex = 13;
            this.delOperatii.Text = "Eliminare operatii";
            this.delOperatii.UseVisualStyleBackColor = true;
            // 
            // addLista
            // 
            this.addLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.addLista.Location = new System.Drawing.Point(392, 586);
            this.addLista.Name = "addLista";
            this.addLista.Size = new System.Drawing.Size(181, 61);
            this.addLista.TabIndex = 12;
            this.addLista.Text = "Adaugare piese";
            this.addLista.UseVisualStyleBackColor = true;
            // 
            // addOperatii
            // 
            this.addOperatii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.addOperatii.Location = new System.Drawing.Point(18, 586);
            this.addOperatii.Name = "addOperatii";
            this.addOperatii.Size = new System.Drawing.Size(181, 61);
            this.addOperatii.TabIndex = 11;
            this.addOperatii.Text = "Adaugare operatii";
            this.addOperatii.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(510, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Operatii:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Liste operatii:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // operatiiGrid
            // 
            this.operatiiGrid.AllowUserToAddRows = false;
            this.operatiiGrid.AllowUserToDeleteRows = false;
            this.operatiiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operatiiGrid.Location = new System.Drawing.Point(514, 47);
            this.operatiiGrid.Name = "operatiiGrid";
            this.operatiiGrid.ReadOnly = true;
            this.operatiiGrid.RowHeadersWidth = 51;
            this.operatiiGrid.RowTemplate.Height = 24;
            this.operatiiGrid.Size = new System.Drawing.Size(731, 499);
            this.operatiiGrid.TabIndex = 8;
            // 
            // lOperatiiGrid
            // 
            this.lOperatiiGrid.AllowUserToAddRows = false;
            this.lOperatiiGrid.AllowUserToDeleteRows = false;
            this.lOperatiiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lOperatiiGrid.Location = new System.Drawing.Point(16, 47);
            this.lOperatiiGrid.Name = "lOperatiiGrid";
            this.lOperatiiGrid.ReadOnly = true;
            this.lOperatiiGrid.RowHeadersWidth = 51;
            this.lOperatiiGrid.RowTemplate.Height = 24;
            this.lOperatiiGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lOperatiiGrid.Size = new System.Drawing.Size(463, 499);
            this.lOperatiiGrid.TabIndex = 7;
            this.lOperatiiGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lOperatiiGrid_CellContentClick);
            // 
            // durataMaxim
            // 
            this.durataMaxim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.durataMaxim.Location = new System.Drawing.Point(701, 592);
            this.durataMaxim.Margin = new System.Windows.Forms.Padding(4);
            this.durataMaxim.Name = "durataMaxim";
            this.durataMaxim.ReadOnly = true;
            this.durataMaxim.Size = new System.Drawing.Size(83, 27);
            this.durataMaxim.TabIndex = 49;
            // 
            // durataLista
            // 
            this.durataLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.durataLista.Location = new System.Drawing.Point(701, 557);
            this.durataLista.Margin = new System.Windows.Forms.Padding(4);
            this.durataLista.Name = "durataLista";
            this.durataLista.ReadOnly = true;
            this.durataLista.Size = new System.Drawing.Size(138, 27);
            this.durataLista.TabIndex = 48;
            this.durataLista.Text = "\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(558, 595);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 47;
            this.label3.Text = "Durata maxima:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(528, 560);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 22);
            this.label4.TabIndex = 46;
            this.label4.Text = "Durata toatala lista:";
            // 
            // Lista_operatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 698);
            this.Controls.Add(this.durataMaxim);
            this.Controls.Add(this.durataLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delOperatii);
            this.Controls.Add(this.addLista);
            this.Controls.Add(this.addOperatii);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operatiiGrid);
            this.Controls.Add(this.lOperatiiGrid);
            this.Name = "Lista_operatii";
            this.Text = "Lista_operatii";
            this.Load += new System.EventHandler(this.Lista_operatii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.operatiiGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOperatiiGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delOperatii;
        private System.Windows.Forms.Button addLista;
        private System.Windows.Forms.Button addOperatii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView operatiiGrid;
        private System.Windows.Forms.DataGridView lOperatiiGrid;
        private System.Windows.Forms.TextBox durataMaxim;
        private System.Windows.Forms.TextBox durataLista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}