namespace Front2
{
    partial class fmrModificacionDeStock
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combitodeproductos = new System.Windows.Forms.ComboBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.RadioDefectuosos = new System.Windows.Forms.RadioButton();
            this.GruopBox = new System.Windows.Forms.GroupBox();
            this.RadioOtros = new System.Windows.Forms.RadioButton();
            this.RadioVencidos = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.GruopBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificacion de stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Elija una opcion : ";
            // 
            // combitodeproductos
            // 
            this.combitodeproductos.FormattingEnabled = true;
            this.combitodeproductos.Location = new System.Drawing.Point(144, 69);
            this.combitodeproductos.Name = "combitodeproductos";
            this.combitodeproductos.Size = new System.Drawing.Size(121, 21);
            this.combitodeproductos.TabIndex = 4;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(144, 118);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 5;
            // 
            // RadioDefectuosos
            // 
            this.RadioDefectuosos.AutoSize = true;
            this.RadioDefectuosos.Location = new System.Drawing.Point(33, 24);
            this.RadioDefectuosos.Name = "RadioDefectuosos";
            this.RadioDefectuosos.Size = new System.Drawing.Size(125, 17);
            this.RadioDefectuosos.TabIndex = 6;
            this.RadioDefectuosos.Text = "Cantidad Defectuosa";
            this.RadioDefectuosos.UseVisualStyleBackColor = true;
            // 
            // GruopBox
            // 
            this.GruopBox.Controls.Add(this.RadioOtros);
            this.GruopBox.Controls.Add(this.RadioVencidos);
            this.GruopBox.Controls.Add(this.RadioDefectuosos);
            this.GruopBox.Location = new System.Drawing.Point(177, 161);
            this.GruopBox.Name = "GruopBox";
            this.GruopBox.Size = new System.Drawing.Size(200, 144);
            this.GruopBox.TabIndex = 7;
            this.GruopBox.TabStop = false;
            // 
            // RadioOtros
            // 
            this.RadioOtros.AutoSize = true;
            this.RadioOtros.Location = new System.Drawing.Point(33, 103);
            this.RadioOtros.Name = "RadioOtros";
            this.RadioOtros.Size = new System.Drawing.Size(50, 17);
            this.RadioOtros.TabIndex = 8;
            this.RadioOtros.Text = "Otros";
            this.RadioOtros.UseVisualStyleBackColor = true;
            // 
            // RadioVencidos
            // 
            this.RadioVencidos.AutoSize = true;
            this.RadioVencidos.Location = new System.Drawing.Point(33, 60);
            this.RadioVencidos.Name = "RadioVencidos";
            this.RadioVencidos.Size = new System.Drawing.Size(112, 17);
            this.RadioVencidos.TabIndex = 7;
            this.RadioVencidos.Text = "Articulos Vencidos";
            this.RadioVencidos.UseVisualStyleBackColor = true;
            this.RadioVencidos.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "En caso de sacar stock, porner la cantidad en negativo";
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(144, 345);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 9;
            this.btnaceptar.Text = "ACEPTAR";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(404, 345);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // fmrModificacionDeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GruopBox);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.combitodeproductos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmrModificacionDeStock";
            this.Text = "fmrModificacionDeStock";
            this.Load += new System.EventHandler(this.fmrModificacionDeStock_Load);
            this.GruopBox.ResumeLayout(false);
            this.GruopBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combitodeproductos;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.RadioButton RadioDefectuosos;
        private System.Windows.Forms.GroupBox GruopBox;
        private System.Windows.Forms.RadioButton RadioOtros;
        private System.Windows.Forms.RadioButton RadioVencidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
    }
}