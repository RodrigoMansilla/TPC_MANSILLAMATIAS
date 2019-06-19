namespace Front2
{
    partial class frmNuevoCp
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
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtPartido = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCp = new System.Windows.Forms.Label();
            this.lblPartido = new System.Windows.Forms.Label();
            this.lblProvinvia = new System.Windows.Forms.Label();
            this.comboProvincias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(194, 48);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(213, 20);
            this.txtCP.TabIndex = 0;
            // 
            // txtPartido
            // 
            this.txtPartido.Location = new System.Drawing.Point(194, 97);
            this.txtPartido.Name = "txtPartido";
            this.txtPartido.Size = new System.Drawing.Size(213, 20);
            this.txtPartido.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(115, 207);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(316, 207);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(90, 54);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(100, 13);
            this.lblCp.TabIndex = 5;
            this.lblCp.Text = "CODIGO POSTAL :";
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(90, 104);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(64, 13);
            this.lblPartido.TabIndex = 6;
            this.lblPartido.Text = "PARTIDO : ";
            // 
            // lblProvinvia
            // 
            this.lblProvinvia.AutoSize = true;
            this.lblProvinvia.Location = new System.Drawing.Point(90, 157);
            this.lblProvinvia.Name = "lblProvinvia";
            this.lblProvinvia.Size = new System.Drawing.Size(65, 13);
            this.lblProvinvia.TabIndex = 7;
            this.lblProvinvia.Text = "PROVINCIA";
            // 
            // comboProvincias
            // 
            this.comboProvincias.FormattingEnabled = true;
            this.comboProvincias.Location = new System.Drawing.Point(194, 148);
            this.comboProvincias.Name = "comboProvincias";
            this.comboProvincias.Size = new System.Drawing.Size(213, 21);
            this.comboProvincias.TabIndex = 8;
            // 
            // frmNuevoCp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 267);
            this.Controls.Add(this.comboProvincias);
            this.Controls.Add(this.lblProvinvia);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.lblCp);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPartido);
            this.Controls.Add(this.txtCP);
            this.Name = "frmNuevoCp";
            this.Text = "frmNuevoCp";
            this.Load += new System.EventHandler(this.frmNuevoCp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtPartido;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.Label lblProvinvia;
        private System.Windows.Forms.ComboBox comboProvincias;
    }
}