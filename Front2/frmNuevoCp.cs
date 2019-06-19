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
    public partial class frmNuevoCp : Form
    {
        private Cp CpLocal = null;

        public frmNuevoCp()
        {
            InitializeComponent();
        }
        public frmNuevoCp(Cp cp)
        {
            InitializeComponent();
            CpLocal = cp;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtCP.Text.Trim() == ""|| txtPartido.Text.Trim()=="")
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }
            CPNegocio negocio = new CPNegocio();
            try
            {
                if (CpLocal == null) CpLocal = new Cp();
                CpLocal.CodigoPostal = Convert.ToInt32(txtCP.Text);
                CpLocal.Partido = txtPartido.Text;
                CpLocal.Provincia = Convert.ToString(comboProvincias.SelectedItem);
                negocio.AgregarCP(CpLocal);
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); ;
            }

        }

        private void frmNuevoCp_Load(object sender, EventArgs e)
        {
            ProvinciaNegocio provinciaNegocio = new ProvinciaNegocio();
            try
            {
                comboProvincias.DataSource = provinciaNegocio.ListarProvincias();

                if (CpLocal == null)
                {
                    txtCP.Text = CpLocal.CodigoPostal.ToString();
                    txtPartido.Text = CpLocal.Partido.ToString();
                    comboProvincias.SelectedIndex = comboProvincias.FindString(CpLocal.Provincia);

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
