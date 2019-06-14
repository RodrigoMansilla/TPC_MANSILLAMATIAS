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
                    mar.Id = (int)accesoDatos.Lector["Id"];
                    mar.Nombre = accesoDatos.Lector["Nombre"].ToString();
                    listado.Add(mar);
                }
                return listado;

            }/*public class CategoriaNegocio
    {
        public List<Categoria> ListarCategorias()
        {
            List<Categoria> listado = new List<Categoria>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Categoria cat = new Categoria();
            try
            {
                accesoDatos.setearConsulta("Select ID, Nombre from Categorias where Estado = 1 ");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    cat = new Categoria();
                    cat.ID = (int)accesoDatos.Lector["ID"];
                    cat.Nombre = accesoDatos.Lector["Nombre"].ToString();
                    listado.Add(cat);
                }
                return listado;

            }*/
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
