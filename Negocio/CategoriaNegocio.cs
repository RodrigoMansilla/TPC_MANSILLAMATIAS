using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AceesoDatos;
using Dominio; 

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> ListarCategorias()
        {
            List<Categoria> listado = new List<Categoria>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Categoria cat = new Categoria();
            try
            {
                accesoDatos.setearConsulta("Select ID, Nombre from Categorias");
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

        public void AgregarCate(Categoria nueva)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearSP("SPAgregarCategoria");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", nueva.Nombre);
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

