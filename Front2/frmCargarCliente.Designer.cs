namespace Front2
{
    partial class frmCargarCliente
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
            this.lblCargaClientes = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFnac = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.TxtTelefon = new System.Windows.Forms.TextBox();
            this.dtpFnac = new System.Windows.Forms.DateTimePicker();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblPartido = new System.Windows.Forms.Label();
            this.txtDirecion = new System.Windows.Forms.TextBox();
            this.comboPartidos = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCargaClientes
            // 
            this.lblCargaClientes.AutoSize = true;
            this.lblCargaClientes.Location = new System.Drawing.Point(108, 37);
            this.lblCargaClientes.Name = "lblCargaClientes";
            this.lblCargaClientes.Size = new System.Drawing.Size(117, 13);
            this.lblCargaClientes.TabIndex = 0;
            this.lblCargaClientes.Text = "CARGA DE CLIENTES";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(35, 97);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 155);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(35, 210);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "APELLIDO";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(35, 259);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "TELEFONO";
            // 
            // lblFnac
            // 
            this.lblFnac.AutoSize = true;
            this.lblFnac.Location = new System.Drawing.Point(35, 381);
            this.lblFnac.Name = "lblFnac";
            this.lblFnac.Size = new System.Drawing.Size(130, 13);
            this.lblFnac.TabIndex = 5;
            this.lblFnac.Text = "FECHA DE NACIMIENTO";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(197, 94);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(200, 20);
            this.txtDni.TabIndex = 6;
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(197, 152);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(200, 20);
            this.Txtnombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(197, 207);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // TxtTelefon
            // 
            this.TxtTelefon.Location = new System.Drawing.Point(197, 259);
            this.TxtTelefon.Name = "TxtTelefon";
            this.TxtTelefon.Size = new System.Drawing.Size(200, 20);
            this.TxtTelefon.TabIndex = 9;
            // 
            // dtpFnac
            // 
            this.dtpFnac.Location = new System.Drawing.Point(197, 381);
            this.dtpFnac.Name = "dtpFnac";
            this.dtpFnac.Size = new System.Drawing.Size(200, 20);
            this.dtpFnac.TabIndex = 10;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(570, 97);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 16;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Location = new System.Drawing.Point(570, 207);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(40, 13);
            this.lblPartido.TabIndex = 17;
            this.lblPartido.Text = "Partido";
            // 
            // txtDirecion
            // 
            this.txtDirecion.Location = new System.Drawing.Point(476, 134);
            this.txtDirecion.Name = "txtDirecion";
            this.txtDirecion.Size = new System.Drawing.Size(291, 20);
            this.txtDirecion.TabIndex = 18;
            // 
            // comboPartidos
            // 
            this.comboPartidos.FormattingEnabled = true;
            this.comboPartidos.Location = new System.Drawing.Point(476, 241);
            this.comboPartidos.Name = "comboPartidos";
            this.comboPartidos.Size = new System.Drawing.Size(291, 21);
            this.comboPartidos.TabIndex = 19;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(476, 377);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 32);
            this.btnAceptar.TabIndex = 20;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(660, 377);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 32);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(197, 322);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(200, 20);
            this.txtCorreoElectronico.TabIndex = 23;
            
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(35, 322);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(132, 13);
            this.lblMail.TabIndex = 22;
            this.lblMail.Text = "CORREO ELECTRONICO";
            
            // 
            // frmCargarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.comboPartidos);
            this.Controls.Add(this.txtDirecion);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.dtpFnac);
            this.Controls.Add(this.TxtTelefon);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.Txtnombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblFnac);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblCargaClientes);
            this.Name = "frmCargarCliente";
            this.Text = "frmCargarCliente";
            this.Load += new System.EventHandler(this.frmCargarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCargaClientes;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFnac;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox TxtTelefon;
        private System.Windows.Forms.DateTimePicker dtpFnac;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.TextBox txtDirecion;
        private System.Windows.Forms.ComboBox comboPartidos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblMail;
    }
}