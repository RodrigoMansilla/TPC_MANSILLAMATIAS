namespace Front2
{
    partial class frmHistoricoStock
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
            this.dgvStockHistorico = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStockHistorico
            // 
            this.dgvStockHistorico.AllowUserToAddRows = false;
            this.dgvStockHistorico.AllowUserToDeleteRows = false;
            this.dgvStockHistorico.AllowUserToOrderColumns = true;
            this.dgvStockHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockHistorico.Location = new System.Drawing.Point(87, 98);
            this.dgvStockHistorico.MultiSelect = false;
            this.dgvStockHistorico.Name = "dgvStockHistorico";
            this.dgvStockHistorico.ReadOnly = true;
            this.dgvStockHistorico.Size = new System.Drawing.Size(597, 301);
            this.dgvStockHistorico.TabIndex = 0;
            // 
            // frmHistoricoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStockHistorico);
            this.Name = "frmHistoricoStock";
            this.Text = "frmHistoricoStock";
            this.Load += new System.EventHandler(this.frmHistoricoStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockHistorico;
    }
}