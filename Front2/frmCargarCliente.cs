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

namespace Front2
{
    public partial class frmCargarCliente : Form
    {
        private Cliente ClienteLocal = null;

        public frmCargarCliente()
        {
            InitializeComponent();
        }

        public frmCargarCliente(Cliente cliente)
        {
            InitializeComponent();
            ClienteLocal = cliente;
        }

        private void frmCargarCliente_Load(object sender, EventArgs e)
        {
            CPNegocio cPNegocio = new CPNegocio();
            try
            {
                comboPartidos.DataSource = cPNegocio.listarCp();

                if (ClienteLocal != null){
                    txtDni.Text = ClienteLocal.DNI.ToString();
                    txtApellido.Text = ClienteLocal.Apellido.ToString();
                    Txtnombre.Text = ClienteLocal.Nombre.ToString();
                    TxtTelefon.Text = ClienteLocal.Telefono.ToString();
                    txtCorreoElectronico.Text = ClienteLocal.Telefono.ToString();
                    dtpFnac.Text = ClienteLocal.FNac.ToShortDateString();
                    txtDirecion.Text = ClienteLocal.CalleYNumero.ToString();
                    comboPartidos.SelectedItem = comboPartidos.FindString(ClienteLocal.cp.Partido);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        // BOTON ACEPTAR

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Trim() == "" || Txtnombre.Text.Trim() == "" || txtApellido.Text.Trim() == "" || txtCorreoElectronico.Text.Trim() == "" || TxtTelefon.Text.Trim() == "" || txtDirecion.Text.Trim() == "")
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }

            ClienteNegocio negocio = new ClienteNegocio();
            try
            {
                if (ClienteLocal == null)
                    ClienteLocal = new Cliente();
                ClienteLocal.DNI = Convert.ToInt32(txtDni.Text);
                ClienteLocal.Nombre = Txtnombre.Text;
                ClienteLocal.Apellido = txtApellido.Text;
                ClienteLocal.Telefono = Convert.ToInt32(TxtTelefon.Text);
                ClienteLocal.Mail = txtCorreoElectronico.Text;
                ClienteLocal.FNac = Convert.ToDateTime(dtpFnac.Text);
                ClienteLocal.CalleYNumero = txtDirecion.Text;
                ClienteLocal.cp = (Cp)comboPartidos.SelectedItem;

                if (ClienteLocal.ID != 0)
                {
                    negocio.modificarCliente(ClienteLocal);
                }
                else
                {
                    negocio.agregarCliente(ClienteLocal);
                }

                Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
