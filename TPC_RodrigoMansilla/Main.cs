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
            submenuproductos.Visible = true;
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            submenuproductos.Visible = false;
            Productos asd = new Productos();
            asd.ShowDialog();
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            submenuproductos.Visible = false;
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
    }
}
