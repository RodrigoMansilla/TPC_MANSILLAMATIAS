using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Front2;

namespace TPC_RodrigoMansilla
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            SubMenuCompras.Visible = false;
            submenuproductos.Visible = true;
            subMenuStock.Visible = false;

        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            submenuproductos.Visible = false;
            Productos asd = new Productos();
            asd.ShowDialog();
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            SubMenuCompras.Visible = false;
            FrmCompra nueva = new FrmCompra();
            nueva.ShowDialog();
        }

        private void btnModStock_Click(object sender, EventArgs e)
        {
            submenuproductos.Visible = false;
            fmrModificacionDeStock nueva = new fmrModificacionDeStock();
            nueva.ShowDialog();
        }

        private void btnvercategorias_Click(object sender, EventArgs e)
        {
            submenuproductos.Visible = false;
            ListaCategorias asd = new ListaCategorias();
            asd.ShowDialog();
        }
        

        private void Main_Load(object sender, EventArgs e)
        {
            labelfechahora.Text = String.Format("{0:G}", DateTime.Now);

        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            SubMenuCompras.Visible = true;
            submenuproductos.Visible = false;
            subMenuStock.Visible = false;


        }

        private void btnHistorialCompra_Click(object sender, EventArgs e)
        {
            frmHistoricoCompras nuevo = new frmHistoricoCompras();
            nuevo.ShowDialog();
        }

        private void labelfechahora_Click(object sender, EventArgs e)
        {

        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            labelfechahora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            subMenuStock.Visible = true;
            submenuproductos.Visible = false;
            SubMenuCompras.Visible = false;
        }

        private void btnHisticoStock_Click(object sender, EventArgs e)
        {
            frmHistoricoStock nuevo = new frmHistoricoStock();
            nuevo.ShowDialog();
        }

        private void btncp_Click(object sender, EventArgs e)
        {
            frmNuevoCp nuevo = new frmNuevoCp();
            nuevo.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCargarCliente nueva = new frmCargarCliente();
            nueva.ShowDialog();
        }
    }
}
