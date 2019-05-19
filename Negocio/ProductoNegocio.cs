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
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Producto> listado = new List<Producto>();
            Producto nuevo;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                
                comando.CommandText = "select p.ID, p.Descripcion, p.Marca, p.PrecioCompra, p.PrecioVenta, p.Ganancia, p.stock1, p.StockMinimo, c.Nombre,p.Comentarios, p.IdCategoria 'Categoria' from Productos as p inner join Categorias as c on c.ID = p.IdCategoria ";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    
                    nuevo = new Producto();
                    nuevo.ID = lector.GetInt32(0);
                    if (!Convert.IsDBNull(lector["Descripcion"])) nuevo.Descripcion = lector.GetString(1);
                    if (!Convert.IsDBNull(lector["PrecioCompra"])) nuevo.PrecioCompra = lector.GetDecimal(3);
                    if (!Convert.IsDBNull(lector["PrecioVenta"])) nuevo.PrecioVenta = lector.GetDecimal(4);
                    if (!Convert.IsDBNull(lector["Ganancia"])) nuevo.Ganancia = lector.GetDecimal(5);
                    if (!Convert.IsDBNull(lector["stock1"])) nuevo.stock1 = lector.GetInt32(6);
                    if (!Convert.IsDBNull(lector["StockMinimo"])) nuevo.StockMinimo = lector.GetInt32(7);
                    if (!Convert.IsDBNull(lector["Comentarios"])) nuevo.Comentarios = lector["Comentarios"].ToString();
                    if (!Convert.IsDBNull(lector["Marca"])) nuevo.Marca = lector["Marca"].ToString();

                    nuevo.Categoria = new Categoria();
                    nuevo.Categoria.ID = lector.GetInt32(10);
                    nuevo.Categoria.Nombre = lector["Nombre"].ToString();
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
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                
                comando.CommandText = "insert into Productos (Descripcion,IdCategoria,PrecioCompra,PrecioVenta,Ganancia,stock1, StockMinimo, Comentarios,Marca) values ";
                comando.CommandText += "('" + nuevo.Descripcion + "', " + nuevo.Categoria.ID.ToString() + ",'" + nuevo.PrecioCompra + "', '" + nuevo.PrecioVenta.ToString() + "', '" + nuevo.Ganancia.ToString() + "', '" + nuevo.stock1.ToString() + "', '" + nuevo.StockMinimo.ToString() + "', '" + nuevo.Comentarios.ToString() + "', '" + nuevo.Marca.ToString() +  "')";
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
            }
        }

        public void modificarProducto(Producto modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {

                accesoDatos.setearConsulta("update Productos Set Descripcion=@Descripcion, Marca=@Marca" + modificar.ID.ToString());
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Descripcion", modificar.Descripcion);
                accesoDatos.Comando.Parameters.AddWithValue("@Marca", modificar.Marca);
               
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

    


