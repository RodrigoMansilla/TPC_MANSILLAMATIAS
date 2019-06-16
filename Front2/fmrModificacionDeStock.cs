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

        public fmrModificacionDeStock(ModificacionStock nuevo)
        {
            InitializeComponent();
            Productolocal = nuevo;
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



                if (Productolocal != null)
                {
                    combitodeproductos.SelectedIndex = combitodeproductos.FindString(Productolocal.NameProduct);
                txtCant.Text = Productolocal.Cantidad.ToString();

                    MessageBox.Show("Hola");
                    bool isChecked = RadioDefectuosos.Checked;


                if (RadioDefectuosos.Checked == true)
                {
                        
                    Productolocal.Comentarios = RadioDefectuosos.Text;
                }

                isChecked = RadioVencidos.Checked;

                if (RadioVencidos.Checked == true) {
                      
                        Productolocal.Comentarios = RadioVencidos.Text;
                        
                }

                isChecked = RadioOtros.Checked;

                if (RadioOtros.Checked == true)
                {
                    Productolocal.Comentarios = RadioOtros.Text;
                }
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

            if (txtCant.Text.Trim() == "" )
            {
                MessageBox.Show("Debes completar todos los campos");
                return;
            }

            ModificaciondeStockNegocio negocio = new ModificaciondeStockNegocio();
            try
            {
                if (Productolocal == null)
                    Productolocal = new ModificacionStock();

            
                Productolocal.NameProduct = Convert.ToString(combitodeproductos.SelectedItem);
                Productolocal.Cantidad = Convert.ToInt32(txtCant.Text);
                if (RadioDefectuosos.Checked == true)
                {
                    
                    Productolocal.Comentarios = Convert.ToString(RadioDefectuosos.Text);
                }
                
                if (RadioOtros.Checked == true)
                {
                    
                    Productolocal.Comentarios = Convert.ToString(RadioOtros.Text);
                }

                if (RadioVencidos.Checked == true)
                {
                    Productolocal.Comentarios = Convert.ToString(RadioVencidos.Text);
                }
                negocio.agregarModificacionStock(Productolocal);
                negocio.UpdateProductos(Productolocal);
                Close();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



    }
}
