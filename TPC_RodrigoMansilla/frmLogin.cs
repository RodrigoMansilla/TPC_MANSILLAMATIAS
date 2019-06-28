using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;
using AceesoDatos;


namespace TPC_RodrigoMansilla
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Trim() == "" || txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }

            UsuarioNegocio negocio = new UsuarioNegocio();
            var validar = negocio.LoginUser(txtUsuario.Text, txtContraseña.Text);
            if (validar == true)
            {
                this.Hide();
                Main nuevo = new Main();
                nuevo.ShowDialog();
                nuevo.FormClosed += Logout;


            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
        private void Logout(object sender,FormClosedEventArgs e)
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
            frmLogin nuevo = new frmLogin();
            nuevo.ShowDialog();

        }
    }
}
