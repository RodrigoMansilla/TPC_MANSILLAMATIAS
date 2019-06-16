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
    public class CompraNegocio
    {

        public List<Compra> ListarCompras()
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Compra> listado = new List<Compra>();
            
            Compra Com = new Compra();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select p.nombre, c.Cantidad, c.PrecioCompra, c.PrecioVenta, c.Ganancia, c.FCompra from Productos as p inner join compras as c on c.IdProducto = p.ID";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (accesoDatos.Lector.Read())
                {
                    Com = new Compra();
                    
                    Com.Cantidad = lector.GetInt32(0);
                    Com.PrecioCompra = lector.GetDecimal(1);
                    Com.PrecioVenta = lector.GetDecimal(2);
                    Com.Ganancia = lector.GetDecimal(3);
                    Com.FCompra = lector.GetDateTime(4);

                    listado.Add(Com);
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
