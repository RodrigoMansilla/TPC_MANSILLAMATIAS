using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AceesoDatos;
using System.Data.SqlClient;

namespace Negocio
{
    public class VentaNegocio
    {
        public List<Venta> ListarVentas(int i)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Venta> listado = new List<Venta>();
            Venta nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select *from ventas where IdCliente = " + i;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Venta();
                    nuevo.Id = lector.GetInt32(0);
                    nuevo.Total = lector.GetDecimal(2);
                    nuevo.Fcompra = lector.GetDateTime(3);
                    listado.Add(nuevo);
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
