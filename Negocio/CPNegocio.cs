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
    public class CPNegocio
    {

        // LISTA DE cps 

        public List<Cp> listarCp()
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Cp> listado = new List<Cp>();
            Cp nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select *from cp";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    nuevo = new Cp();
                    nuevo.CodigoPostal = lector.GetInt32(0);
                    nuevo.Partido = lector.GetString(1);
                    nuevo.Provincia = lector.GetString(2);
                   
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
