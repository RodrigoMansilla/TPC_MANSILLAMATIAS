using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Collections;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using AceesoDatos;
using System.Data.SqlClient;
using Common.Cache;

namespace AppWeb
{
    public partial class fmrCompra : System.Web.UI.Page
    {
        private ArrayList ProductosSelecionados = new ArrayList();
        
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Inicializar();
                CompraTruchaNegocio compraTruchaNegocio = new CompraTruchaNegocio();
                List<MostrarP> lista = compraTruchaNegocio.listarP();
                gvProductos.DataSource = lista;
                gvProductos.DataBind();
            }
        }

        private void Inicializar()
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select p.Id,p.Nombre from Productos as p where p.estado=1";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                int i = 0;
                while (lector.Read())
                {
                    TreeViewProductos.Nodes.Add(new TreeNode());
                    TreeViewProductos.Nodes[i].Text = lector["Nombre"].ToString();
                    TreeViewProductos.Nodes[i].Value = lector["Id"].ToString();
                    i++;
                }
                lector.Close();
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

        protected void TreeViewProductos_SelectedNodeChanged(object sender, EventArgs e)
        {
            
            int a;
            btnVerCarro.Visible = true;
            btnAceptar.Visible = true;
            ComboStock.Visible = true;
            TreeNode nodo = TreeViewProductos.SelectedNode;
            a=Cargadelabels(nodo.Value);
            cargacombo(a);
            lblNombre.Visible = true;
            lblPrecioVenta.Visible = true;
            lblStock.Visible = true;

        }

        private int Cargadelabels(string id)
        {
            int arba=0;
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select *from productos where id =" + id;
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    lblNombre.Text = "NOMBRE : " + lector["Nombre"].ToString();
                    lblPrecioVenta.Text = "PRECIO : " + lector["PrecioVenta"].ToString();
                    lblStock.Text = "STOCK " + lector["Stock"].ToString();
                    arba = lector.GetInt32(4);
                }
                lector.Close();
                conexion.Dispose();
                return arba;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
        }

        private void cargacombo(int numero)
        {
            int i;
            ComboStock.Items.Clear();
            for (i = 0; i < numero; i++)
            {
                ComboStock.Items.Add(Convert.ToString(i+1));
            }

        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            this.ProductosSelecionados = (ArrayList)this.ViewState["productoCarro"];
            
        }

        protected override object SaveViewState()
        {
            this.ViewState.Add("productoCarro", ProductosSelecionados);
            return base.SaveViewState();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            TreeNode node = TreeViewProductos.SelectedNode;
            ProductosSelecionados.Add(node.Value);
            ProductosSelecionados.Add(ComboStock.SelectedValue);
            int i = 0;
            ArrayList producto = this.ProductosSelecionados;
            DataTable dt = new DataTable();
            dt.Columns.Add("idProducto");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("PrecioVenta");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Subtotal");


            for (i = 0; i < producto.Count; i = i + 2)
            {
                AccesoDatosManager accesoDatos = new AccesoDatosManager();
                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();
                SqlDataReader lector;
                List<ClaseParaListarCarro> listado = new List<ClaseParaListarCarro>();
                ClaseParaListarCarro nuevo;
                try
                {
                    conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = "select p.Nombre, p.PrecioVenta, (select p.Estado * " + producto[i + 1] + ") as cantidad, (select p.PrecioVenta *" + producto[i + 1] + ") as Subtotal from Productos as p where ID =" + producto[i];
                    comando.Connection = conexion;
                    conexion.Open();
                    lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        nuevo = new ClaseParaListarCarro();
                        nuevo.Nombre = lector["Nombre"].ToString();
                        nuevo.PrecioVenta = nuevo.PrecioVenta = lector.GetDecimal(1);
                        nuevo.SubTotal = nuevo.SubTotal = lector.GetDecimal(3);
                        dt.Rows.Add(producto[i], nuevo.Nombre, nuevo.PrecioVenta, producto[i + 1], nuevo.SubTotal);
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
            DVCarrito.DataSource = dt;
            DVCarrito.DataBind();
            lbltoto.Visible = true;
            decimal suma = 0;
            foreach (DataRow dr in dt.Rows)
            {
                suma = suma + Convert.ToDecimal(dr[4]);
            }
            lblNtotal.Text = suma.ToString();
            btnFinalizarCompra.Visible = true;
            
        }

        protected void btnVerCarro_Click(object sender, EventArgs e)
        {
           
        }
        protected void gvProductos_RowCreated(object sender, GridViewRowEventArgs e)
        {


        }

        

        protected void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            GraboVenta();  // aca grabo la venta sin el detalle de los productos 
            

            GraboDetalle();// aca grabo los detalles de venta 

            
            Mmodstock(); // ACA TENGO MODIFICO EL STOCK, DEL PRODUCTO QUE VENDI


            Response.Redirect("~/frmFactura.aspx");
        }

       private void Mmodstock(){

            int i = 0;
            ArrayList producto = ProductosSelecionados;

            for (i = 0; i < producto.Count; i = i + 2)
            {
                AccesoDatosManager accesoDatos1 = new AccesoDatosManager();
                try
                {
                    accesoDatos1.setearSP("SPActStock");
                    accesoDatos1.Comando.Parameters.Clear();
                    accesoDatos1.Comando.Parameters.AddWithValue("@id", producto[i]);
                    accesoDatos1.Comando.Parameters.AddWithValue("@cant", producto[i + 1]);
                    accesoDatos1.abrirConexion();
                    accesoDatos1.ejecutarAccion();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    accesoDatos1.cerrarConexion();
                }

            }
        }
    private void GraboDetalle()
        {

            int i = 0;
            ArrayList producto = ProductosSelecionados;

            for (i = 0; i < producto.Count; i = i + 2)
            {
                AccesoDatosManager accesoDatos1 = new AccesoDatosManager();
                try
                {
                    accesoDatos1.setearSP("SpNuevosDetalles");
                    accesoDatos1.Comando.Parameters.Clear();
                    accesoDatos1.Comando.Parameters.AddWithValue("@correo", Common.Cache.UserLoginCache.Correo);
                    accesoDatos1.Comando.Parameters.AddWithValue("@id", producto[i]);
                    accesoDatos1.Comando.Parameters.AddWithValue("@cant", producto[i + 1]);
                    accesoDatos1.abrirConexion();
                    accesoDatos1.ejecutarAccion();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    accesoDatos1.cerrarConexion();
                }
            }
        }

        private void GraboVenta()
        {
            decimal kiko;
            kiko = Convert.ToDecimal(lblNtotal.Text);
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearSP("SpCreaVenta");
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@correo", Common.Cache.UserLoginCache.Correo);
                accesoDatos.Comando.Parameters.AddWithValue("@to", kiko);
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