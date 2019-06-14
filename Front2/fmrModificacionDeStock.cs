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
    public partial class fmrModificacionDeStock : Form
    {
        private ModificacionStock Productolocal = null;

        public fmrModificacionDeStock()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fmrModificacionDeStock_Load(object sender, EventArgs e)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();
            try
            {
                combitodeproductos.DataSource = productoNegocio.listarProductos();
                combitodeproductos.SelectedIndex = combitodeproductos.FindString(Productolocal.NameProduct);
                txtCant.Text = Productolocal.Cantidad.ToString();
            //string value = "";

            bool isChecked = RadioDefectuosos.Checked;

                if (isChecked)
                {
                    Productolocal.Comentarios = RadioDefectuosos.Text;
                }

                isChecked = RadioVencidos.Checked;

                if (isChecked) { 
                    Productolocal.Comentarios = RadioVencidos.Text;
                }

                isChecked = RadioOtros.Checked;

                if (isChecked)
                {
                    Productolocal.Comentarios = RadioOtros.Text;
                }


                //ComboProductos.SelectedIndex = ComboProductos.FindString(Productolocal.Nombre);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //ModificacionStock negocio = new ModificacionStock();
            ModificaciondeStockNegocio negocio = new ModificaciondeStockNegocio();
            try
            {
                if (Productolocal == null)
                    Productolocal = new ModificacionStock();

                /* Productolocal.Nombre = Convert.ToString(ComboProductos.SelectedItem);
                 Productolocal.Stock = Convert.ToInt32(txtCantidad.Text);
                 Productolocal.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                 Productolocal.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);

                 // UPDATEA PRODUCTOS 

                 negocio.modificarProducto2(Productolocal);

                 // CREA REGISTRO EN TABLA COMPRAS 
                 negocio.agregarCompra(Productolocal);*/

                Productolocal.NameProduct = Convert.ToString(combitodeproductos.SelectedItem);
                Productolocal.Cantidad = Convert.ToInt32(txtCant.Text);
                if (RadioDefectuosos.Checked == true)
                {
                    Productolocal.Comentarios = Convert.ToString(RadioDefectuosos.Text);
                }
                
                if (RadioOtros.Checked == true)
                {
                    Productolocal.Comentarios = Convert.ToString(RadioVencidos.Text);
                }

                if (RadioVencidos.Checked == true)
                {
                    Productolocal.Comentarios = Convert.ToString(RadioOtros.Text);
                }
                negocio.agregarModificacionStock(Productolocal);
                Close();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
