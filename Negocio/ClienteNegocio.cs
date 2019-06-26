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
    public class ClienteNegocio
    {
        public void agregarCliente(Cliente nuevo)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearSP("Sp_AgregarCliente");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@dn", nuevo.DNI);
                accesoDatos.Comando.Parameters.AddWithValue("@nom", nuevo.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@ap", nuevo.Apellido);
                accesoDatos.Comando.Parameters.AddWithValue("@tl", nuevo.Telefono);
                accesoDatos.Comando.Parameters.AddWithValue("@co", nuevo.Mail);
                accesoDatos.Comando.Parameters.AddWithValue("@fn", nuevo.FNac);
                accesoDatos.Comando.Parameters.AddWithValue("@cn", nuevo.CalleYNumero);
                accesoDatos.Comando.Parameters.AddWithValue("@part", nuevo.Codigo.CodigoPostal);

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

        public void modificarCliente (Cliente nuevo)
        {



        }

    }
}
