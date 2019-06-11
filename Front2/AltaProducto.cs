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

                MarcaNegocio marcaNegocio = new MarcaNegocio();

                try
                {
                    ComboCategoria.DataSource = categoriaNegocio.ListarCategorias();
                    ComboMarcas.DataSource = marcaNegocio.ListarMarcas();
                    

                    if (ProductoLocal != null)
                    {
                        textBoxNombre.Text = ProductoLocal.Nombre.ToString();
                        ComboMarcas.SelectedIndex = ComboMarcas.FindString(ProductoLocal.Marca.Nombre);
                        textBoxStockMinimo.Text = ProductoLocal.StockMinimo.ToString();
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
        }

        private void ComboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBoxComentarios_TextChanged(object sender, EventArgs e)
        {
                    }

        private void lblComent_Click(object sender, EventArgs e)
        {

        }
    }
}
