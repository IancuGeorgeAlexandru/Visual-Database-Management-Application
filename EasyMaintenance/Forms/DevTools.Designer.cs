namespace EasyMaintenance.Forms
{
    partial class DevTools
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
            this.label1 = new System.Windows.Forms.Label();
            this.query = new System.Windows.Forms.TextBox();
            this.devGrid = new System.Windows.Forms.DataGridView();
            this.openConn = new System.Windows.Forms.Button();
            this.closeConn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.executeQuery = new System.Windows.Forms.Button();
            this.resetQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.devGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Query:";
            // 
            // query
            // 
            this.query.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.query.Location = new System.Drawing.Point(82, 81);
            this.query.Multiline = true;
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(992, 146);
            this.query.TabIndex = 1;
            // 
            // devGrid
            // 
            this.devGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devGrid.Location = new System.Drawing.Point(82, 247);
            this.devGrid.Name = "devGrid";
            this.devGrid.RowHeadersWidth = 51;
            this.devGrid.RowTemplate.Height = 24;
            this.devGrid.Size = new System.Drawing.Size(1226, 464);
            this.devGrid.TabIndex = 2;
            // 
            // openConn
            // 
            this.openConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.openConn.Location = new System.Drawing.Point(12, 12);
            this.openConn.Name = "openConn";
            this.openConn.Size = new System.Drawing.Size(228, 49);
            this.openConn.TabIndex = 3;
            this.openConn.Text = "Open Connection";
            this.openConn.UseVisualStyleBackColor = true;
            this.openConn.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeConn
            // 
            this.closeConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.closeConn.Location = new System.Drawing.Point(252, 12);
            this.closeConn.Name = "closeConn";
            this.closeConn.Size = new System.Drawing.Size(228, 49);
            this.closeConn.TabIndex = 4;
            this.closeConn.Text = "Close Connection";
            this.closeConn.UseVisualStyleBackColor = true;
            this.closeConn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(486, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Connection status:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.status.Location = new System.Drawing.Point(651, 26);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 22);
            this.status.TabIndex = 6;
            // 
            // executeQuery
            // 
            this.executeQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.executeQuery.Location = new System.Drawing.Point(1080, 81);
            this.executeQuery.Name = "executeQuery";
            this.executeQuery.Size = new System.Drawing.Size(228, 49);
            this.executeQuery.TabIndex = 8;
            this.executeQuery.Text = "Execute Query";
            this.executeQuery.UseVisualStyleBackColor = true;
            this.executeQuery.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // resetQuery
            // 
            this.resetQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.resetQuery.Location = new System.Drawing.Point(1080, 178);
            this.resetQuery.Name = "resetQuery";
            this.resetQuery.Size = new System.Drawing.Size(228, 49);
            this.resetQuery.TabIndex = 9;
            this.resetQuery.Text = "Reset Query";
            this.resetQuery.UseVisualStyleBackColor = true;
            this.resetQuery.Click += new System.EventHandler(this.resetQuery_Click);
            // 
            // DevTools
            // 
            this.AcceptButton = this.executeQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 737);
            this.Controls.Add(this.resetQuery);
            this.Controls.Add(this.executeQuery);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeConn);
            this.Controls.Add(this.openConn);
            this.Controls.Add(this.devGrid);
            this.Controls.Add(this.query);
            this.Controls.Add(this.label1);
            this.Name = "DevTools";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DevTools_Load);
            ((System.ComponentModel.ISupportInitialize)(this.devGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox query;
        private System.Windows.Forms.DataGridView devGrid;
        private System.Windows.Forms.Button openConn;
        private System.Windows.Forms.Button closeConn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button executeQuery;
        private System.Windows.Forms.Button resetQuery;
    }
}