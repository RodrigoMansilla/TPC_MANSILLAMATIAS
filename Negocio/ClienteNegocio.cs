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
        public List<Cliente> listarCliente()
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Cliente> listado = new List<Cliente>();
            Cliente nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from Clientes";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    nuevo = new Cliente();
                    nuevo.ID = lector.GetInt32(0);
                    nuevo.DNI = lector.GetInt32(1);
                    nuevo.Nombre = lector.GetString(3);
                    nuevo.Apellido = lector.GetString(4);
                    nuevo.Telefono = lector.GetInt32(5);
                    nuevo.Mail = lector.GetString(6);
                    nuevo.contrasenia = lector.GetString(7);
                    nuevo.FNac = lector.GetDateTime(8);
                    nuevo.CalleYNumero = lector.GetString(9);
                    nuevo.FAlta = lector.GetDateTime(10);

                    nuevo.cp = new Cp();
                    nuevo.cp.CodigoPostal = (int)lector["Cp"];
                    nuevo.cp.CodigoPostal = lector.GetInt32(2);
                    


/*                    nuevo.Categoria = new Categoria();
                    nuevo.Categoria.ID = (int)lector["Id"];
                    nuevo.Categoria.Nombre = lector.GetString(2);*/

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
                accesoDatos.Comando.Parameters.AddWithValue("@pass", nuevo.contrasenia);
                accesoDatos.Comando.Parameters.AddWithValue("@fn", nuevo.FNac);
                accesoDatos.Comando.Parameters.AddWithValue("@cn", nuevo.CalleYNumero);
                accesoDatos.Comando.Parameters.AddWithValue("@part", nuevo.cp.CodigoPostal);

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
