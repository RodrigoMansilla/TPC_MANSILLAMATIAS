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
    public partial class FrmCompra : Form
    {
        private Compra Compralocal = null;

        public FrmCompra()
        {
            InitializeComponent();
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            {
                
                ProductoNegocio productoNegocio = new ProductoNegocio();

                try
                {
                    ComboProductos.DataSource = productoNegocio.listarProductos();


                    if (Compralocal != null)
                    {
                        //ComboProductos.SelectedIndex = ComboProductos.FindString(Compralocal.IdProducto);
                        txtCantidad.Text = Compralocal.Cantidad.ToString();

                        //ComboMarcas.SelectedIndex = ComboMarcas.FindString(ProductoLocal.Marca.Nombre);
                        //textBoxStockMinimo.Text = ProductoLocal.StockMinimo.ToString();
                        //ComboCategoria.SelectedIndex = ComboCategoria.FindString(ProductoLocal.Categoria.Nombre);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
