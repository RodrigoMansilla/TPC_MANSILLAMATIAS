﻿using System;
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
                comando.CommandText = "select p.Id, p.Nombre, c.Nombre, m.Nombre,p.stock,p.stockminimo,p.preciocompra,p.precioventa,p.ganancia,p.estado from Productos as p inner join categorias as c on p.Idcategoria = C.Id inner join Marcas as m on m.id=p.IdMarca";
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

                    /*nuevo.Categoria.ID = (int)lector["ID"];
                    nuevo.Categoria.Nombre = lector.GetString(8);*/
                    

                    /*
                    nuevo.Universo = new Universo();
                    nuevo.Universo.Id = (int)lector["IdUniverso"];
                    nuevo.Universo.Nombre = lector["Descripcion"].ToString();*/

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
                conexion.Close();
            }
        }
        /// <summary>
        ///  aca
        /// </summary>
        /// <param name="nuevo"></param>
        public void agregarProducto(Producto nuevo)
        {
           /* SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                
                comando.CommandText = "insert into Productos (Descripcion,IdCategoria,PrecioCompra,PrecioVenta,Ganancia,stock1, StockMinimo, Comentarios,Marca,Estado) values ";
                comando.CommandText += "('" + nuevo.Descripcion + "', " + nuevo.Categoria.ID.ToString() + ",'" + nuevo.PrecioCompra + "', '" + nuevo.PrecioVenta.ToString() + "', '" + nuevo.Ganancia.ToString() + "', '" + nuevo.stock1.ToString() + "', '" + nuevo.StockMinimo.ToString() + "', '" + nuevo.Comentarios.ToString() + "', '" + nuevo.Marca.ToString() + "','" + 1+"')";
                //comando.CommandText += "('" + nuevo.Nombre + "', '" + nuevo.Debilidad + "', '" + nuevo.UsaCapa.ToString() + "', '"+ nuevo.Volador.ToString() + "',"+ nuevo.Universo.Id.ToString() + ")";
                comando.Connection = conexion;
                conexion.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }*/
        }

        public void modificarProducto(Producto modificar)
        {
           /* AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearSP("SPModificarProducto");

                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@aydi", modificar.ID);
                accesoDatos.Comando.Parameters.AddWithValue("@des1", modificar.Descripcion);
                accesoDatos.Comando.Parameters.AddWithValue("@pc", modificar.PrecioCompra);
                accesoDatos.Comando.Parameters.AddWithValue("@pv", modificar.PrecioVenta);
                accesoDatos.Comando.Parameters.AddWithValue("@gan", modificar.Ganancia);
                accesoDatos.Comando.Parameters.AddWithValue("@stock", modificar.stock1);
                accesoDatos.Comando.Parameters.AddWithValue("@stm", modificar.StockMinimo);
                accesoDatos.Comando.Parameters.AddWithValue("@com", modificar.Comentarios);
                accesoDatos.Comando.Parameters.AddWithValue("@Mr", modificar.Marca);
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
            }*/
        }

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

    


