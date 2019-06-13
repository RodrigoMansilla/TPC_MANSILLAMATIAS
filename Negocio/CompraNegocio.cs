using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AceesoDatos;
using Dominio;

namespace Negocio
{
    public class CompraNegocio
    {

        public List<Compra> ListarCompras()
        {
            List<Compra> listado = new List<Compra>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Compra Com = new Compra();
            try
            {
                accesoDatos.setearConsulta("Select ID, Nombre from Categorias where Estado = 1 ");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    Com = new Compra();
                    Com.IdCompra = (int)accesoDatos.Lector["ID"];
                    //Com. = accesoDatos.Lector["Nombre"].ToString();
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
