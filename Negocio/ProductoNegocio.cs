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
    public  class ProductoNegocio
    {

        // LISTA DE PRODUCTOS 

        public List<Producto> listarProductos()
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Producto> listado = new List<Producto>();
            Producto nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select p.Id, p.Nombre, c.Nombre, m.Nombre,p.stock,p.stockminimo,p.preciocompra,p.precioventa,p.ganancia,p.estado from Productos as p inner join categorias as c on p.Idcategoria = C.Id inner join Marcas as m on m.id=p.IdMarca where p.estado=1";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    
                    nuevo = new Producto();
                    nuevo.ID = lector.GetInt32(0);
                    if (!Convert.IsDBNull(lector["Nombre"])) nuevo.Nombre = lector["Nombre"].ToString();
                    if (!Convert.IsDBNull(lector["stock"])) nuevo.Stock = lector.GetInt32(4);
                    if (!Convert.IsDBNull(lector["StockMinimo"])) nuevo.StockMinimo = lector.GetInt32(5);
                    if (!Convert.IsDBNull(lector["PrecioCompra"])) nuevo.PrecioCompra = lector.GetDecimal(6);
                    if (!Convert.IsDBNull(lector["PrecioVenta"])) nuevo.PrecioVenta = lector.GetDecimal(7);
                    if (!Convert.IsDBNull(lector["Ganancia"])) nuevo.Ganancia = lector.GetDecimal(8);


                    nuevo.Categoria = new Categoria();
                    nuevo.Categoria.ID = (int)lector["Id"];
                    nuevo.Categoria.Nombre = lector.GetString(2);

                    nuevo.Marca = new Marca();
                    nuevo.Marca.Id = (int)lector["Id"];
                    nuevo.Marca.Nombre = lector.GetString(3);

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

        // AGREGO PRODUCTOS 

        public void agregarProducto(Producto nuevo)
        {
              AccesoDatosManager accesoDatos = new AccesoDatosManager();
             try
             {
                 accesoDatos.setearSP("Sp_AgregarProducto");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@nom", nuevo.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@idcat", nuevo.Categoria.ID);
                accesoDatos.Comando.Parameters.AddWithValue("@idmarca", nuevo.Marca.Id);
                accesoDatos.Comando.Parameters.AddWithValue("@stm", nuevo.StockMinimo);
                
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
        

        // LOS MODIFICO 

        public void modificarProducto(Producto modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearSP("SPModificarProducto");

                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@aydi", modificar.ID);
                accesoDatos.Comando.Parameters.AddWithValue("@Nom", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@stm", modificar.StockMinimo);
                accesoDatos.Comando.Parameters.AddWithValue("@Mar", modificar.Marca.Id);
                //accesoDatos.Comando.Parameters.AddWithValue("@IdUni", modificar.Universo.Id);
                accesoDatos.Comando.Parameters.AddWithValue("@idcat", modificar.Categoria.ID);
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

        // LOS MODIFICO DESDE COMPRA 

        public void modificarProducto2(Producto modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearSP("SPModificarProducto2");

                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nom", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@stock", modificar.Stock);
                accesoDatos.Comando.Parameters.AddWithValue("@preciocompra", modificar.PrecioCompra);
                accesoDatos.Comando.Parameters.AddWithValue("@precioventa", modificar.PrecioVenta);
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

        // AGREGO COMPRA

        public void agregarCompra(Producto nuevo)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearSP("SPAgregarCompra");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@nom", nuevo.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@cant", nuevo.Stock);
                accesoDatos.Comando.Parameters.AddWithValue("@PC", nuevo.PrecioCompra);
                accesoDatos.Comando.Parameters.AddWithValue("@PV", nuevo.PrecioVenta);
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

       


        // ELIMINO PRODUCTOS 

        public void EliminarProducto(Producto Elimiar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("update Productos set Estado = 0 where ID =  " + Elimiar.ID.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("0", Elimiar.Estado);
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
                System.Windows.Forms.MessageBox.Show("Se elimino correctamente");
            }
        }
        

    }
}

    


