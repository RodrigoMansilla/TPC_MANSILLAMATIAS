﻿namespace TPC_RodrigoMansilla
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btncp = new System.Windows.Forms.Button();
            this.submenuproductos = new System.Windows.Forms.Panel();
            this.btnvercategorias = new System.Windows.Forms.Button();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.btnModStock = new System.Windows.Forms.Button();
            this.btnNuevaCompra = new System.Windows.Forms.Button();
            this.labelfechahora = new System.Windows.Forms.Label();
            this.SubMenuCompras = new System.Windows.Forms.Panel();
            this.btnHistorialCompra = new System.Windows.Forms.Button();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.lblfecha = new System.Windows.Forms.Label();
            this.subMenuStock = new System.Windows.Forms.Panel();
            this.btnHisticoStock = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Compras = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SubMenuClientes = new System.Windows.Forms.Panel();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnVerClientes = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.submenuproductos.SuspendLayout();
            this.SubMenuCompras.SuspendLayout();
            this.subMenuStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Compras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SubMenuClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.Location = new System.Drawing.Point(37, 94);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(102, 23);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.Location = new System.Drawing.Point(37, 149);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(102, 23);
            this.btnCompras.TabIndex = 1;
            this.btnCompras.Text = "COMPRAS";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnStock
            // 
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.Location = new System.Drawing.Point(37, 208);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(102, 23);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "STOCK";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Location = new System.Drawing.Point(37, 261);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(102, 23);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btncp
            // 
            this.btncp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncp.Location = new System.Drawing.Point(37, 320);
            this.btncp.Name = "btncp";
            this.btncp.Size = new System.Drawing.Size(102, 23);
            this.btncp.TabIndex = 4;
            this.btncp.Text = "NUEVO CP ";
            this.btncp.UseVisualStyleBackColor = true;
            this.btncp.Click += new System.EventHandler(this.btncp_Click);
            // 
            // submenuproductos
            // 
            this.submenuproductos.AllowDrop = true;
            this.submenuproductos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.submenuproductos.Controls.Add(this.btnvercategorias);
            this.submenuproductos.Controls.Add(this.btnVerProductos);
            this.submenuproductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submenuproductos.Location = new System.Drawing.Point(158, 117);
            this.submenuproductos.Name = "submenuproductos";
            this.submenuproductos.Size = new System.Drawing.Size(206, 86);
            this.submenuproductos.TabIndex = 5;
            this.submenuproductos.Visible = false;
            // 
            // btnvercategorias
            // 
            this.btnvercategorias.Location = new System.Drawing.Point(0, 48);
            this.btnvercategorias.Name = "btnvercategorias";
            this.btnvercategorias.Size = new System.Drawing.Size(197, 23);
            this.btnvercategorias.TabIndex = 3;
            this.btnvercategorias.Text = "VER CATEGORIAS PRODUCTOS";
            this.btnvercategorias.UseVisualStyleBackColor = true;
            this.btnvercategorias.Click += new System.EventHandler(this.btnvercategorias_Click);
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
            // btnModStock
            // 
            this.btnModStock.Location = new System.Drawing.Point(0, 14);
            this.btnModStock.Name = "btnModStock";
            this.btnModStock.Size = new System.Drawing.Size(197, 23);
            this.btnModStock.TabIndex = 2;
            this.btnModStock.Text = "MODIFICAR STOCK";
            this.btnModStock.UseVisualStyleBackColor = true;
            this.btnModStock.Click += new System.EventHandler(this.btnModStock_Click);
            // 
            // btnNuevaCompra
            // 
            this.btnNuevaCompra.Location = new System.Drawing.Point(3, 3);
            this.btnNuevaCompra.Name = "btnNuevaCompra";
            this.btnNuevaCompra.Size = new System.Drawing.Size(197, 23);
            this.btnNuevaCompra.TabIndex = 1;
            this.btnNuevaCompra.Text = "NUEVA COMPRA";
            this.btnNuevaCompra.UseVisualStyleBackColor = true;
            this.btnNuevaCompra.Click += new System.EventHandler(this.btnNuevaCompra_Click);
            // 
            // labelfechahora
            // 
            this.labelfechahora.AutoSize = true;
            this.labelfechahora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelfechahora.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfechahora.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelfechahora.Location = new System.Drawing.Point(598, 364);
            this.labelfechahora.Name = "labelfechahora";
            this.labelfechahora.Size = new System.Drawing.Size(179, 63);
            this.labelfechahora.TabIndex = 6;
            this.labelfechahora.Text = "label1";
            this.labelfechahora.Click += new System.EventHandler(this.labelfechahora_Click);
            // 
            // SubMenuCompras
            // 
            this.SubMenuCompras.AllowDrop = true;
            this.SubMenuCompras.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SubMenuCompras.Controls.Add(this.btnHistorialCompra);
            this.SubMenuCompras.Controls.Add(this.btnNuevaCompra);
            this.SubMenuCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubMenuCompras.Location = new System.Drawing.Point(158, 152);
            this.SubMenuCompras.Name = "SubMenuCompras";
            this.SubMenuCompras.Size = new System.Drawing.Size(206, 82);
            this.SubMenuCompras.TabIndex = 4;
            this.SubMenuCompras.Visible = false;
            // 
            // btnHistorialCompra
            // 
            this.btnHistorialCompra.Location = new System.Drawing.Point(3, 56);
            this.btnHistorialCompra.Name = "btnHistorialCompra";
            this.btnHistorialCompra.Size = new System.Drawing.Size(197, 23);
            this.btnHistorialCompra.TabIndex = 2;
            this.btnHistorialCompra.Text = "HISTORIAL DE COMPRAS";
            this.btnHistorialCompra.UseVisualStyleBackColor = true;
            this.btnHistorialCompra.Click += new System.EventHandler(this.btnHistorialCompra_Click);
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.Black;
            this.lblfecha.Location = new System.Drawing.Point(39, 376);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(126, 46);
            this.lblfecha.TabIndex = 7;
            this.lblfecha.Text = "label1";
            // 
            // subMenuStock
            // 
            this.subMenuStock.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.subMenuStock.Controls.Add(this.btnHisticoStock);
            this.subMenuStock.Controls.Add(this.btnModStock);
            this.subMenuStock.Location = new System.Drawing.Point(158, 184);
            this.subMenuStock.Name = "subMenuStock";
            this.subMenuStock.Size = new System.Drawing.Size(206, 100);
            this.subMenuStock.TabIndex = 8;
            this.subMenuStock.Visible = false;
            // 
            // btnHisticoStock
            // 
            this.btnHisticoStock.Location = new System.Drawing.Point(0, 60);
            this.btnHisticoStock.Name = "btnHisticoStock";
            this.btnHisticoStock.Size = new System.Drawing.Size(197, 23);
            this.btnHisticoStock.TabIndex = 3;
            this.btnHisticoStock.Text = "REGISTRO DE MOD. STOCK";
            this.btnHisticoStock.UseVisualStyleBackColor = true;
            this.btnHisticoStock.Click += new System.EventHandler(this.btnHisticoStock_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Compras
            // 
            this.Compras.Image = ((System.Drawing.Image)(resources.GetObject("Compras.Image")));
            this.Compras.InitialImage = ((System.Drawing.Image)(resources.GetObject("Compras.InitialImage")));
            this.Compras.Location = new System.Drawing.Point(2, 138);
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(29, 34);
            this.Compras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Compras.TabIndex = 9;
            this.Compras.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // SubMenuClientes
            // 
            this.SubMenuClientes.Controls.Add(this.btnNuevoCliente);
            this.SubMenuClientes.Controls.Add(this.btnVerClientes);
            this.SubMenuClientes.Location = new System.Drawing.Point(158, 261);
            this.SubMenuClientes.Name = "SubMenuClientes";
            this.SubMenuClientes.Size = new System.Drawing.Size(206, 100);
            this.SubMenuClientes.TabIndex = 12;
            this.SubMenuClientes.Visible = false;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(0, 17);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(206, 23);
            this.btnNuevoCliente.TabIndex = 13;
            this.btnNuevoCliente.Text = "NUEVO CLIENTE";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.Location = new System.Drawing.Point(0, 52);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Size = new System.Drawing.Size(206, 23);
            this.btnVerClientes.TabIndex = 12;
            this.btnVerClientes.Text = "VER CLIENTES";
            this.btnVerClientes.UseVisualStyleBackColor = true;
            this.btnVerClientes.Click += new System.EventHandler(this.btnVerClientes_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 244);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(665, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "label1";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(665, 67);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 17;
            this.lblCargo.Text = "label3";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(665, 102);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(35, 13);
            this.lblCorreo.TabIndex = 18;
            this.lblCorreo.Text = "label4";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.SubMenuClientes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Compras);
            this.Controls.Add(this.subMenuStock);
            this.Controls.Add(this.SubMenuCompras);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.labelfechahora);
            this.Controls.Add(this.btncp);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.submenuproductos);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.submenuproductos.ResumeLayout(false);
            this.SubMenuCompras.ResumeLayout(false);
            this.subMenuStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Compras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SubMenuClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btncp;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.Button btnModStock;
        private System.Windows.Forms.Button btnNuevaCompra;
        private System.Windows.Forms.Button btnvercategorias;
        private System.Windows.Forms.Label labelfechahora;
        private System.Windows.Forms.Button btnHistorialCompra;
        public System.Windows.Forms.Panel submenuproductos;
        public System.Windows.Forms.Panel SubMenuCompras;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Panel subMenuStock;
        private System.Windows.Forms.Button btnHisticoStock;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox Compras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel SubMenuClientes;
        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblCorreo;
    }
}