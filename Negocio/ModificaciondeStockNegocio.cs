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
                accesoDatos.Comando.Parameters.AddWithValue("@cant", nuevo.Cantidad); accesoDatos.Comando.Parameters.AddWithValue("@Coment", nuevo.Comentarios);
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
    }
}
