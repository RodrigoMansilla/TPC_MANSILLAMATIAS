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

        private void ListaCategorias_Load(object sender, EventArgs e)
        {
            CargarListaCategorias();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
