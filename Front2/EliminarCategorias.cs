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

// EL CODIGO DEL FORMULARIO PARA ELIMINAR PRODUCTOS 

namespace Front2
{
    public partial class EliminarCategorias : Form
    {

        private Categoria categoriaLocal = null;

        public EliminarCategorias()
        {
            InitializeComponent();
        }

        //creo constructor

        public EliminarCategorias(Categoria cat) 
        {
            InitializeComponent();
            categoriaLocal = cat;
        }

        // CIERRO LA VENTANA Y CANCELO LA OPERACION

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // ACEPT0 LA ELIMINACION.

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            negocio.EliminarCategorias(categoriaLocal);
            Visible = false; // aca oculto el form(ELIMINAR) una vez que elijo la opcion
            
        }
    }
}
