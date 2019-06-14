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
        
        private Producto Productolocal = null;

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


                    if (Productolocal != null)
                    {
                        ComboProductos.SelectedIndex = ComboProductos.FindString(Productolocal.Nombre);
                        txtCantidad.Text = Productolocal.Stock.ToString();
                        txtPrecioCompra.Text = Productolocal.PrecioCompra.ToString();
                        txtPrecioVenta.Text = Productolocal.PrecioVenta.ToString();

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
            ProductoNegocio negocio = new ProductoNegocio();
            try
            {
                if (Productolocal == null)
                    Productolocal = new Producto();

                Productolocal.Nombre = Convert.ToString(ComboProductos.SelectedItem);
                MessageBox.Show(Productolocal.Nombre);
                Productolocal.Stock = Convert.ToInt32(txtCantidad.Text);//bien
                Productolocal.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                Productolocal.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                
                /*   ProductoLocal.Descripcion = textBoxNombre.Text;
                ProductoLocal.PrecioCompra = Convert.ToDecimal(textBoxPrecioCompra.Text);
                ProductoLocal.PrecioVenta = Convert.ToDecimal(textBoxPrecioVenta.Text);
                ProductoLocal.Ganancia = Convert.ToDecimal(textBoxGanancia.Text);
                ProductoLocal.stock1 = Convert.ToInt32(textBoxStock.Text);
                ProductoLocal.StockMinimo = Convert.ToInt32(textBoxStockMinimo.Text);
                ProductoLocal.Comentarios = textBoxComentarios.Text;
                ProductoLocal.Marca = textBoxMarca.Text;
                ProductoLocal.Categoria = (Categoria)ComboCategoria.SelectedItem;*/

                negocio.modificarProducto2(Productolocal);
                Close();
                MessageBox.Show("llegue aca");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // BOTON CANCELAR 

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /*// BOTON ACEPTAR

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            try
            {
                if (ProductoLocal == null)
                    ProductoLocal = new Producto();


                ProductoLocal.Nombre = textBoxNombre.Text;
                ProductoLocal.StockMinimo = Convert.ToInt32(textBoxStockMinimo.Text);
                ProductoLocal.Marca = (Marca)ComboMarcas.SelectedItem;
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
        }*/
    }
}
