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
    public partial class AltaProducto : Form
    {
        private Producto ProductoLocal = null;
        public AltaProducto()
        {
            InitializeComponent();
        }
        public AltaProducto(Producto producto)
        {
            InitializeComponent();
            ProductoLocal = producto;
        }
        

        private void AltaProducto_Load(object sender, EventArgs e)
        {
            {
                
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

                try
                {
                    ComboCategoria.DataSource = categoriaNegocio.ListarCategorias();

                    if (ProductoLocal != null)
                    {
                        textBoxNombre.Text = ProductoLocal.Descripcion.ToString();
                        textBoxMarca.Text = ProductoLocal.Marca.ToString();
                        textBoxPrecioCompra.Text = ProductoLocal.PrecioCompra.ToString();
                        textBoxPrecioVenta.Text = ProductoLocal.PrecioVenta.ToString();
                        textBoxGanancia.Text = ProductoLocal.Ganancia.ToString();
                        textBoxStock.Text = ProductoLocal.stock1.ToString();
                        textBoxStockMinimo.Text = ProductoLocal.StockMinimo.ToString();
                        textBoxComentarios.Text = ProductoLocal.Comentarios.ToString();
                        ComboCategoria.SelectedIndex = ComboCategoria.FindString(ProductoLocal.Categoria.Nombre);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }



            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            try
            {
                if (ProductoLocal == null)
                    ProductoLocal = new Producto();


                ProductoLocal.Descripcion = textBoxNombre.Text;
                ProductoLocal.PrecioCompra = Convert.ToDecimal(textBoxPrecioCompra.Text);
                ProductoLocal.PrecioVenta = Convert.ToDecimal(textBoxPrecioVenta.Text);
                ProductoLocal.Ganancia = Convert.ToDecimal(textBoxGanancia.Text);
                ProductoLocal.stock1 = Convert.ToInt32(textBoxStock.Text);
                ProductoLocal.StockMinimo = Convert.ToInt32(textBoxStockMinimo.Text);
                ProductoLocal.Comentarios = textBoxComentarios.Text;
                ProductoLocal.Marca = textBoxMarca.Text;
                ProductoLocal.Categoria = (Categoria)ComboCategoria.SelectedItem;




                if (ProductoLocal.ID != 0)
                {
                   negocio.modificarProducto(ProductoLocal);
                }
                else
                {
                    negocio.agregarProducto(ProductoLocal);
                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ComboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
