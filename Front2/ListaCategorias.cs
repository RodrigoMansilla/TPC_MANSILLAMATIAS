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

namespace Front2
{
    public partial class ListaCategorias : Form
    {
        private List<Categoria> listacate;

        public ListaCategorias()
        {
            InitializeComponent();
        }

        // CARGA LAS CATEGORIAS EN LA LISTA .

        private void CargarListaCategorias()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                listacate = negocio.ListarCategorias();
                dvgcategoria.DataSource = listacate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // CARGA DEL FORMULARIO, CARGA LAS CATEGORIAS EN LA DVG 

        private void ListaCategorias_Load(object sender, EventArgs e)
        {
            CargarListaCategorias();
        }

        // BOTON CANCELAR 

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // BOTON ELIMINAR CATEGORIAS 

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarCategorias BAJA = new EliminarCategorias((Categoria)dvgcategoria.CurrentRow.DataBoundItem); // aca tengo que hacer un form para la eliminacion de categorias 
                BAJA.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}