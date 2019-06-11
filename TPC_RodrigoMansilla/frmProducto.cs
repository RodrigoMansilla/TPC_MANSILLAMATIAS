
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
using Front2;
using Dominio;

namespace TPC_RodrigoMansilla
{
    public partial class frmProducto : Form
    {
      private List<Producto> listaProductos1;
        
      public frmProducto()
       {
            InitializeComponent();
       }
        // CARGA DEL FORM 

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        // BOTON AGREGAR PRODUCTO

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

            AltaProducto alta = new AltaProducto();
            alta.ShowDialog();
            cargarGrilla();
        }

        // BOTON MODIFICAR 

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                AltaProducto modificar = new AltaProducto((Producto)dgvProductos.CurrentRow.DataBoundItem);
                modificar.ShowDialog();
                cargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // BOTON ELIMINAR 

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Eliminar Alta = new Eliminar((Producto)dgvProductos.CurrentRow.DataBoundItem);
                Alta.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        // BOTON AGREGAR CATEGORIAS 

        private void btnagregarcategorias_Click(object sender, EventArgs e)
        {
            CategoriaNueva nueva = new CategoriaNueva();
            nueva.ShowDialog();
        }

        // FUNCION DE CARGA DE LA GRILLA

        private void cargarGrilla()
    {
    ProductoNegocio negocio = new ProductoNegocio();
    try
    {
                listaProductos1 = negocio.listarProductos();
        dgvProductos.DataSource = listaProductos1;
        dgvProductos.Columns[9].Visible = false;
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.ToString());
    }
}
        
        // TEXTBOX DE LA BUSQUEDA POR NOMBRE DEL PRODUCTO 

        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)
        
            {
                if (txtBusqueda.Text == "")
                {
                    dgvProductos.DataSource = listaProductos1;
                }
                else
                {
                    List<Producto> lista;
                    lista = listaProductos1.FindAll(X => X.Nombre.Contains(txtBusqueda.Text));
                    dgvProductos.DataSource = lista;
                }
            }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnvercategorias_Click(object sender, EventArgs e)
        {
            ListaCategorias nueva = new ListaCategorias();
            nueva.ShowDialog();
        }
    }
}