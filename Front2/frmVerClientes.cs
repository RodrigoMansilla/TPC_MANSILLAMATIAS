using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace Front2
{
    public partial class frmVerClientes : Form
    {
        private List<Cliente> ListarCli;
        public frmVerClientes()
        {
            InitializeComponent();
        }

        private void frmVerClientes_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        public void CargarGrilla ()
        {
            ClienteNegocio negocio = new ClienteNegocio();
            
            try
            {
                ListarCli = negocio.listarCliente();
                dgvVerClientes.DataSource = ListarCli;
                dgvVerClientes.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                dgvVerClientes.DataSource = ListarCli;
            }
            else
            {
                List<Cliente> lista;
                lista = ListarCli.FindAll(X => X.Nombre.Contains(txtNombre.Text));
                dgvVerClientes.DataSource = lista;
            }
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            if (TxtApellido.Text == "")
            {
                dgvVerClientes.DataSource = ListarCli;
            }
            else
            {
                List<Cliente> lista;
                lista = ListarCli.FindAll(X => X.Apellido.Contains(TxtApellido.Text));
                dgvVerClientes.DataSource = lista;
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                dgvVerClientes.DataSource = ListarCli;
            }
            else
            {
                List<Cliente> lista;
                lista = ListarCli.FindAll(X => X.Mail.Contains(txtCorreo.Text));
                dgvVerClientes.DataSource = lista;
            }
        }
    }
}
