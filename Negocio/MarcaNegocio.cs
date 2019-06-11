using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AceesoDatos;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> ListarMarcas()
        {
            List<Marca> listado = new List<Marca>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Marca mar = new Marca();
            try
            {
                accesoDatos.setearConsulta("Select ID, Nombre from Marcas");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    mar = new Marca();
                    mar.Id = (int)accesoDatos.Lector["ID"];
                    mar.Nombre = accesoDatos.Lector["Nombre"].ToString();
                    listado.Add(mar);
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
