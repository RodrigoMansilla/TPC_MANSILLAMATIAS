using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using AceesoDatos;

namespace Negocio
{
   public class ModificaciondeStockNegocio
    {

        // AGREGO LAS MODIFICACIONES DE STOCK 

        public void agregarModificacionStock(ModificacionStock nuevo)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearSP("SPAgregarModificacionSTock");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@name", nuevo.NameProduct);
                accesoDatos.Comando.Parameters.AddWithValue("@cant", nuevo.Cantidad);
                accesoDatos.Comando.Parameters.AddWithValue("@Coment", nuevo.Comentarios);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();

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

        public void UpdateProductos(ModificacionStock nuevo)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearSP("SPUpdateProductos");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@name", nuevo.NameProduct);
                accesoDatos.Comando.Parameters.AddWithValue("@cant", nuevo.Cantidad);
                accesoDatos.Comando.Parameters.AddWithValue("@Coment", nuevo.Comentarios);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();

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

        // creo lista de historico de modificacion de stock

        public List<ModificacionStock> listarHstock()
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<ModificacionStock> listado = new List<ModificacionStock>();
            ModificacionStock nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select *from ModiStock where estado = 1";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    
                    nuevo = new ModificacionStock();
                    nuevo.Id = lector.GetInt32(0);
                    nuevo.IdProducto = lector.GetInt32(1);
                    nuevo.Cantidad = lector.GetInt32(2);
                    nuevo.Comentarios = lector.GetString(3);
                    // aca va la fecha
                    // aca el estado 
                    nuevo.NameProduct = lector.GetString(6);
                    

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
