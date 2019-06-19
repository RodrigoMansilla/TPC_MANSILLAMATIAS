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
    public partial class frmHistoricoStock : Form
    {
        //private List<Producto> listaProductos2;
        private List<ModificacionStock> ListarMH;
        public frmHistoricoStock()
        {
            InitializeComponent();
        }

        private void frmHistoricoStock_Load(object sender, EventArgs e)
        {
            cargarGrilla1();
        }

        public void cargarGrilla1()
        {
            ModificaciondeStockNegocio negocio = new ModificaciondeStockNegocio();
            try
            {
                ListarMH = negocio.listarHstock();
                dgvStockHistorico.DataSource = ListarMH;
                dgvStockHistorico.Columns[5].Visible = false;
                dgvStockHistorico.Columns[6].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
