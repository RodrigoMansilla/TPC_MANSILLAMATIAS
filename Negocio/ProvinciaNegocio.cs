using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AceesoDatos;
using Dominio;

namespace Negocio
{
    public class ProvinciaNegocio
    {
        public List<Provincias> ListarProvincias()
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Provincias> listado = new List<Provincias>();

            Provincias nueva = new Provincias();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select *from provincias";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                { 
                    nueva = new Provincias();
                    nueva.Codigo = lector.GetInt32(0);
                    nueva.Nombre = lector.GetString(1);
                    listado.Add(nueva);
                }
                return listado;

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
