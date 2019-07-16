using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Collections;
using System.Web.UI.WebControls;
using AceesoDatos;
using Common.Cache;
using Negocio;
using System.Data.SqlClient;
using Dominio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Net;
using System.Text;
using iTextSharp.text.html.simpleparser;


namespace AppWeb
{
    public partial class frmFactura : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            Clientes();
            Resumen();
        }
        
        private void Clientes()
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select c.Nombre, c.apellido, c.DNI, c.calle from clientes as c where correo like '" + Common.Cache.UserLoginCache.Correo + "'";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    lblNombres1.Text = lector.GetString(0);
                    lblNombres2.Text = lector.GetString(1);
                    lbldni1.Text = Convert.ToString(lector.GetInt32(2));
                    lbladdres.Text = lector.GetString(3);
                }
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

        private int Factura() {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "declare @aux int select @aux = max(IdFactura) from Ventas select idfactura, total, Fecha from ventas where IdFactura = @aux";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    lblNfactura.Text = Convert.ToString(lector.GetInt32(0));
                    lblCompleto1.Text = Convert.ToString(lector.GetDecimal(1));
                    lblFechaEmision.Text = Convert.ToString(lector.GetDateTime(2));
                }
                return Convert.ToInt32(lblNfactura.Text);
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

        private void Resumen()
        {
            int a;
            a = Factura();
            DataTable name = new DataTable();
            name.Columns.Add("name");
            DataTable cantidad = new DataTable();
            cantidad.Columns.Add("cant");
            DataTable precio = new DataTable();
            precio.Columns.Add("pre");
            DataTable subtotal = new DataTable();
            subtotal.Columns.Add("sub");
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Productos.Nombre, VentasClientes.Cantidad, Productos.PrecioVenta, VentasClientes.Subtotal  from productos inner join VentasClientes on VentasClientes.IdProducto = Productos.ID where VentasClientes.IdFactura = " + a;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                listarventa nuevo;
                while (lector.Read())
                {
                    nuevo = new listarventa();

                    nuevo.nombre = lector.GetString(0);
                    name.Rows.Add(nuevo.nombre);
                    

                    nuevo.cantidad = lector.GetInt32(1);
                    cantidad.Rows.Add(nuevo.cantidad);

                    nuevo.precio = lector.GetDecimal(2);
                    precio.Rows.Add(nuevo.precio);

                    nuevo.subtotal = lector.GetDecimal(3);
                    subtotal.Rows.Add(nuevo.subtotal);
                }
                
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
            gvName.DataSource = name;
            gvName.DataBind();

            Gvcantidad.DataSource = cantidad;
            Gvcantidad.DataBind();

            gvSubtotal.DataSource = subtotal;
            gvSubtotal.DataBind();

            gvPrecio.DataSource = precio;
            gvPrecio.DataBind();
        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=factura.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);

            Panel1.RenderControl(hw);
            StringReader sr = new StringReader(sw.ToString());
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 10f);
            HTMLWorker htmlParser = new HTMLWorker(pdfDoc);
            PdfWriter.GetInstance(pdfDoc, Response.OutputStream);

            pdfDoc.Open();
            htmlParser.Parse(sr);
            pdfDoc.Close();

            Response.Write(pdfDoc);
            Response.End();

        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            return;
        }
    }
}