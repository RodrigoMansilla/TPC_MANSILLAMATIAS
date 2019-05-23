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
    public partial class Eliminar : Form
    {
        private Producto ProductoLocal = null;
        public Eliminar()
        {
            InitializeComponent();
        }


        public Eliminar(Producto producto)
        {
            InitializeComponent();
            ProductoLocal = producto;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }
    }
}
