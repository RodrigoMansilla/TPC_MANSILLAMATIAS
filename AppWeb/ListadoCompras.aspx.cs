using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
using AceesoDatos;
using Common.Cache;
using System.Data.SqlClient;

namespace AppWeb
{
    public partial class ListadoCompras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VentaNegocio ventaNegocio = new VentaNegocio();
            List<Venta> lista = ventaNegocio.ListarVentas(leerIdCliente(Common.Cache.UserLoginCache.Correo));
            gvVentas.DataSource = lista;
            gvVentas.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelid.Text = "se rompio";
        }

        public int leerIdCliente(string id)
        {
            int aux=0;
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select c.DNI from clientes as c where correo like'" + id +"'";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                
                while (lector.Read())
                {
                    aux = lector.GetInt32(0);
                   
                }

                lector.Close();
                return aux;
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

        protected void gvVentas_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Response.Write("<script>window.alert('tocaste la grid1');</script>");
        }

        protected void gvVentas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
        }
    }
}