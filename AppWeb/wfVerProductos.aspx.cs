using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace AppWeb
{
    public partial class wfVerProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio productoNegocio = new ProductoNegocio();
            List<Producto> lista = productoNegocio.listarProductos();
            gvProductos.DataSource = lista;
            gvProductos.DataBind();
            



            /*      
             *      DataGridView1.Columns[1].Visible = false;


             *      dgvVerClientes.DataSource = ListarCli;
                dgvVerClientes.Columns[0].Visible = false;
                dgvVerClientes.Columns[6].Visible = false;        
                dgvVerClientes.Columns[10].Visible = false;*/
        }

        protected void gvProductos_RowCreated(object sender, GridViewRowEventArgs e)
        {
            
        
        }
    }
}