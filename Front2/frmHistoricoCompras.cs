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
    public partial class frmHistoricoCompras : Form
    {
        
        private List<Compra> ListarCompras2;
        public frmHistoricoCompras()
        {
            InitializeComponent();
        }

        private void frmHistoricoCompras_Load(object sender, EventArgs e)
        {
            cargarGrilla2();
        }

        public void cargarGrilla2()
        {
            CompraNegocio negocio = new CompraNegocio();
            try
            {
                ListarCompras2 = negocio.ListarCompras();
                DGVListadeCompras.DataSource = ListarCompras2;
                DGVListadeCompras.Columns[6].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
           /* if (txtbusqueda.Text == "")
            {
                DGVListadeCompras.DataSource = ListarCompras2;
            }
            else
            {
                List<frmHistoricoCompras> lista;
               // lista = ListarCompras2.FindAll(X => X.IdProducto.Contains(txtbusqueda.Text));
                DGVListadeCompras.DataSource = lista;
            }*/
        }
    }

}

