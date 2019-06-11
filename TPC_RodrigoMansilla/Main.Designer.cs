namespace TPC_RodrigoMansilla
{
    partial class Main
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
            this.btnProductos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.submenuproductos = new System.Windows.Forms.Panel();
            this.btnModStock = new System.Windows.Forms.Button();
            this.btnNuevaCompra = new System.Windows.Forms.Button();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.submenuproductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(37, 94);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(102, 23);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(37, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(37, 286);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // submenuproductos
            // 
            this.submenuproductos.Controls.Add(this.btnModStock);
            this.submenuproductos.Controls.Add(this.btnNuevaCompra);
            this.submenuproductos.Controls.Add(this.btnVerProductos);
            this.submenuproductos.Location = new System.Drawing.Point(37, 124);
            this.submenuproductos.Name = "submenuproductos";
            this.submenuproductos.Size = new System.Drawing.Size(200, 100);
            this.submenuproductos.TabIndex = 5;
            this.submenuproductos.Visible = false;

            // 
            // btnModStock
            // 
            this.btnModStock.Location = new System.Drawing.Point(0, 77);
            this.btnModStock.Name = "btnModStock";
            this.btnModStock.Size = new System.Drawing.Size(197, 23);
            this.btnModStock.TabIndex = 2;
            this.btnModStock.Text = "MODIFICAR STOCK";
            this.btnModStock.UseVisualStyleBackColor = true;
            this.btnModStock.Click += new System.EventHandler(this.btnModStock_Click);
            // 
            // btnNuevaCompra
            // 
            this.btnNuevaCompra.Location = new System.Drawing.Point(0, 39);
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(197, 23);
            this.btnNuevaCompra.TabIndex = 1;
            this.btnNuevaCompra.Text = "NUEVA COMPRA";
            this.btnNuevaCompra.UseVisualStyleBackColor = true;
            this.btnNuevaCompra.Click += new System.EventHandler(this.btnNuevaCompra_Click);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Location = new System.Drawing.Point(0, 3);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(197, 23);
            this.btnVerProductos.TabIndex = 0;
            this.btnVerProductos.Text = "VER PRODUCTOS";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submenuproductos);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnProductos);
            this.Name = "Main";
            this.Text = "Main";
            this.submenuproductos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel submenuproductos;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.Button btnModStock;
        private System.Windows.Forms.Button btnNuevaCompra;
    }
}