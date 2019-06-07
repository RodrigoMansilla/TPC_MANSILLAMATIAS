namespace TPC_RodrigoMansilla
{
    partial class frmProducto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnagregarcategorias = new System.Windows.Forms.Button();
            this.btnvercategorias = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(604, 104);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 6;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged_1);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(375, 111);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(146, 13);
            this.lblProductos.TabIndex = 7;
            this.lblProductos.Text = "Buscar productos por nombre";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(25, 142);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(1062, 231);
            this.dgvProductos.TabIndex = 8;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(145, 394);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(543, 394);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(841, 394);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnagregarcategorias
            // 
            this.btnagregarcategorias.Location = new System.Drawing.Point(51, 487);
            this.btnagregarcategorias.Name = "btnagregarcategorias";
            this.btnagregarcategorias.Size = new System.Drawing.Size(576, 23);
            this.btnagregarcategorias.TabIndex = 13;
            this.btnagregarcategorias.Text = "AGREGAR CATEGORIAS DE PRODUCTO";
            this.btnagregarcategorias.UseVisualStyleBackColor = true;
            this.btnagregarcategorias.Click += new System.EventHandler(this.btnagregarcategorias_Click);
            // 
            // btnvercategorias
            // 
            this.btnvercategorias.Location = new System.Drawing.Point(735, 487);
            this.btnvercategorias.Name = "btnvercategorias";
            this.btnvercategorias.Size = new System.Drawing.Size(252, 23);
            this.btnvercategorias.TabIndex = 14;
            this.btnvercategorias.Text = "VER CATEGORIAS";
            this.btnvercategorias.UseVisualStyleBackColor = true;
            this.btnvercategorias.Click += new System.EventHandler(this.btnvercategorias_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(983, 551);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 15;
            this.btncerrar.Text = "CERRAR";
            this.btncerrar.UseVisualStyleBackColor = true;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 586);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnvercategorias);
            this.Controls.Add(this.btnagregarcategorias);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.txtBusqueda);
            this.Name = "frmProducto";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnagregarcategorias;
        private System.Windows.Forms.Button btnvercategorias;
        private System.Windows.Forms.Button btncerrar;
    }
}

