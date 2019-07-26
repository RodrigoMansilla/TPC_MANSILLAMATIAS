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
            Producto nuevo = new Producto();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select c.IdCompra, c.IdProducto, p.nombre, c.Cantidad, c.PrecioCompra, c.PrecioVenta, c.Ganancia, c.Fcompra from compras as c inner join productos as p on p.id=c.idproducto";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Com = new Compra();
                    nuevo = new Producto();

                    Com.IdCompra = lector.GetInt32(0);
                    Com.IdProducto = lector.GetInt32(1);
                    nuevo.Nombre = lector.GetString(2);
                    Com.Cantidad = lector.GetDecimal(3);
                    Com.PrecioCompra = lector.GetDecimal(4);
                    Com.PrecioVenta = lector.GetDecimal(5);
                    Com.Ganancia = lector.GetDecimal(6);
                    Com.FCompra = lector.GetDateTime(7);
                    

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
