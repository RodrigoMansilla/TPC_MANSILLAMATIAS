using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AceesoDatos;
using Dominio;


namespace Negocio
{
    public class CPNegocio
    {
        public void AgregarCP(Cp nuevo)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearSP("SPAgregarCP");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@codigo", nuevo.CodigoPostal);
                accesoDatos.Comando.Parameters.AddWithValue("@par", nuevo.Partido);
                accesoDatos.Comando.Parameters.AddWithValue("@pv", nuevo.Provincia);
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
