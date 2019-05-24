
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

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cargarGrilla();
        }
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

            AltaProducto alta = new AltaProducto();
            alta.ShowDialog();
            cargarGrilla();
        }


        
        private void btnModificar_Click(object sender, EventArgs e)
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


        // EL ELIMINAR ESTA ACA 
        /*debo mostrar todo el producto con un cartel que le pregunte si lo elimino
         en el caso de si
         ir a la base de datos update de estado de ese id en 0
         en el caso de note this.dispose*/

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // ahora  la programacion de "Elimiar" no conoce a Form1 de TCP_RodrigoMansilla. cagamos tengo que mudar el form1 a front2 antes que se siga cagando todo
                Eliminar Alta = new Eliminar((Producto)dgvProductos.CurrentRow.DataBoundItem);
                Alta.ShowDialog();

                // ACA TENGO QUE HACER QUE EL USUARIO NO PUEDA MODIFICAR SOLO LO TENGA COMO LECTURA 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }


        private void txtBusqueda_TextChanged(object sender, EventArgs e)
{
if (txtBusqueda.Text == "")
{
dgvProductos.DataSource = listaProductos1;
}
else
{
List<Producto> lista;
lista = listaProductos1.FindAll(X => X.Descripcion.Contains(txtBusqueda.Text));
dgvProductos.DataSource = lista;
}
}

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
    }
}