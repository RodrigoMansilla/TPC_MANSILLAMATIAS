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
    public partial class Productos : Form
    {
        private List<Producto> listaProductos2;

        public Productos()
        {
            InitializeComponent();
        }

        public void Productos_Load(object sender, EventArgs e)
        {
            cargarGrilla1();
            

        }

        // FUNCION DE CARGA DE LA GRILLA

        public void cargarGrilla1()
        {
            ProductoNegocio negocio = new ProductoNegocio();
            try
            {
                listaProductos2 = negocio.listarProductos();
                dvgProductos1.DataSource = listaProductos2;
                dvgProductos1.Columns[9].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // TEXTBOX DE LA BUSQUEDA POR NOMBRE DEL PRODUCTO 

        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)

        {
            if (txtboxbuscar.Text == "")
            {
                dvgProductos1.DataSource = listaProductos2;
            }
            else
            {
                List<Producto> lista;
                lista = listaProductos2.FindAll(X => X.Nombre.Contains(txtboxbuscar.Text));
                dvgProductos1.DataSource = lista;
            }
        }

        // BOTON AGREGAR 

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaProducto alta = new AltaProducto();
            alta.ShowDialog();
            cargarGrilla1();
        }

        // BOTON  MODIFICAR 

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                AltaProducto modificar = new AltaProducto((Producto)dvgProductos1.CurrentRow.DataBoundItem);
                modificar.ShowDialog();
                cargarGrilla1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // BOTON  ELIMINAR 

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Eliminar Alta = new Eliminar((Producto)dvgProductos1.CurrentRow.DataBoundItem);
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

        // BOTON LISTAR CATEGORIAS 

        private void btnvercategorias_Click(object sender, EventArgs e)
        {
            ListaCategorias nueva = new ListaCategorias();
            nueva.ShowDialog();
        }

        private void txtboxbuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtboxbuscar.Text == "")
            {
                dvgProductos1.DataSource = listaProductos2;
            }
            else
            {
                List<Producto> lista;
                lista = listaProductos2.FindAll(X => X.Nombre.Contains(txtboxbuscar.Text));
                dvgProductos1.DataSource = lista;
            }
        }

        private void dvgProductos1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           /* int A;
            decimal B;
            if (this.dvgProductos1.Columns[e.ColumnIndex].Name == "Stock")
            {
                A = Convert.ToInt32(e.Value);
                B = Convert.ToDecimal(this.dvgProductos1.Columns[e.ColumnIndex].Name == "PrecioVenta");
                MessageBox.Show(Convert.ToString(B));
                if (A < B)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.BackColor = Color.Orange;
                }

            }*/
        }
    }
}
