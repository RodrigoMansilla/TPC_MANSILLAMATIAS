using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            frmProducto asd = new frmProducto();
            asd.ShowDialog();
        }

        private void btnNuevaCompra_Click(object sender, EventArgs e)
        {
            submenuproductos.Visible = false;
        }

        private void btnModStock_Click(object sender, EventArgs e)
        {
            submenuproductos.Visible = false;
        }
    }
}
