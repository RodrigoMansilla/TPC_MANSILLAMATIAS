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
    public partial class CategoriaNueva : Form
    {
        private Categoria categoriaLocal = null;

        public CategoriaNueva()
        {
            InitializeComponent();
        }

        // BOTON ACEPTAR DEL FORM 

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtbxcatnueva.Text.Trim() == "" )
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (categoriaLocal == null)
                    categoriaLocal = new Categoria();

                categoriaLocal.Nombre = txtbxcatnueva.Text;

                negocio.AgregarCate(categoriaLocal);
                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
