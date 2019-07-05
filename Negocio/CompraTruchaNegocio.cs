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
    public class CompraTruchaNegocio
    {
        public List<MostrarP> listarP()
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<MostrarP> listado = new List<MostrarP>();
            MostrarP nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select  p.id,c.Nombre, p.Nombre, m.Nombre, p.PrecioVenta, p.Stock from Productos as p inner join Categorias as c on c.Id = p.IdCategoria inner join marcas as m on m.Id = p.IdMarca where p.estado = 1  ";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    nuevo = new MostrarP();
                    nuevo.Id = lector.GetInt32(0);
                    nuevo.Nombre = lector.GetString(1);
                    nuevo.Categoria = lector.GetString(2);
                    nuevo.Marca = lector.GetString(3);
                    nuevo.PrecioVenta = lector.GetDecimal(4);
                    nuevo.Stock = lector.GetInt32(5);

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
