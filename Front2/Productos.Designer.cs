namespace Front2
{
    partial class Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgProductos1 = new System.Windows.Forms.DataGridView();
            this.btnagregarcategorias = new System.Windows.Forms.Button();
            this.btnvercategorias = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtboxbuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProductos1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgProductos1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgProductos1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgProductos1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProductos1.Location = new System.Drawing.Point(41, 114);
            this.dvgProductos1.Name = "dvgProductos1";
            this.dvgProductos1.ReadOnly = true;
            this.dvgProductos1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProductos1.Size = new System.Drawing.Size(700, 196);
            this.dvgProductos1.TabIndex = 0;
            this.dvgProductos1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dvgProductos1_CellFormatting);
            // 
            // btnagregarcategorias
            // 
            this.btnagregarcategorias.Location = new System.Drawing.Point(414, 397);
            this.btnagregarcategorias.Name = "btnagregarcategorias";
            this.btnagregarcategorias.Size = new System.Drawing.Size(337, 23);
            this.btnagregarcategorias.TabIndex = 2;
            this.btnagregarcategorias.Text = "AGREGAR CATEGORIAS";
            this.btnagregarcategorias.UseVisualStyleBackColor = true;
            this.btnagregarcategorias.Click += new System.EventHandler(this.btnagregarcategorias_Click);
            // 
            // btnvercategorias
            // 
            this.btnvercategorias.Location = new System.Drawing.Point(79, 397);
            this.btnvercategorias.Name = "btnvercategorias";
            this.btnvercategorias.Size = new System.Drawing.Size(312, 23);
            this.btnvercategorias.TabIndex = 3;
            this.btnvercategorias.Text = "LISTAR CATEGORIAS";
            this.btnvercategorias.UseVisualStyleBackColor = true;
            this.btnvercategorias.Click += new System.EventHandler(this.btnvercategorias_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(613, 335);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(128, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(326, 335);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(125, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(75, 335);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(161, 69);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(207, 13);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "BUSCAR PRODUCTOS POR NOMBRE : ";
            // 
            // txtboxbuscar
            // 
            this.txtboxbuscar.Location = new System.Drawing.Point(374, 66);
            this.txtboxbuscar.Name = "txtboxbuscar";
            this.txtboxbuscar.Size = new System.Drawing.Size(100, 20);
            this.txtboxbuscar.TabIndex = 8;
            this.txtboxbuscar.TextChanged += new System.EventHandler(this.txtboxbuscar_TextChanged);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxbuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnvercategorias);
            this.Controls.Add(this.btnagregarcategorias);
            this.Controls.Add(this.dvgProductos1);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProductos1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgProductos1;
        private System.Windows.Forms.Button btnagregarcategorias;
        private System.Windows.Forms.Button btnvercategorias;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtboxbuscar;
    }
}