using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AceesoDatos;
using Common.Cache;
using Negocio;
using System.Data.SqlClient;

namespace AppWeb
{
    public partial class frmFactura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select c.Nombre, c.apellido, c.DNI, c.calle from clientes as c where correo like '" + Common.Cache.UserLoginCache.Correo + "'" ;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    lblNombres1.Text = lector.GetString(0);
                    lblNombres2.Text = lector.GetString(1);
                    lbldni1.Text = Convert.ToString(lector.GetInt32(2));
                    lbladdres.Text = lector.GetString(3);
                }
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