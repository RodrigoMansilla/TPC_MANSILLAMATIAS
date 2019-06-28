using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using AceesoDatos;
using System.Data.SqlClient;
using Common.Cache;

namespace AppWeb
{
    public partial class wfVerProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Inicializar();
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
        private void Inicializar()
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select p.Id,p.Nombre from Productos as p where p.estado=1";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                int i = 0;
                while (lector.Read())
                {
                    TreeViewProductos.Nodes.Add(new TreeNode());
                    TreeViewProductos.Nodes[i].Text = lector["Nombre"].ToString();
                    TreeViewProductos.Nodes[i].Value = lector["Id"].ToString();
                    i++;
                }
                lector.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        protected void TreeViewProductos_SelectedNodeChanged(object sender, EventArgs e)
        {
            TreeNode nodo = TreeViewProductos.SelectedNode;
            Cargadegiladas(nodo.Value);
            lblNombre.Visible = true;
            //lblCantidad.Visible = true;
            lblPrecioVenta.Visible = true;
            lblStock.Visible = true;

        }

        private void Cargadegiladas(string id) {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select *from productos where id =" + id ;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    lblNombre.Text = "NOMBRE : " + lector["Nombre"].ToString();
                    lblPrecioVenta.Text = "PRECIO : " + lector["PrecioVenta"].ToString();
                    lblStock.Text = "STOCK " + lector["Stock"].ToString();
                }
                lector.Close();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}