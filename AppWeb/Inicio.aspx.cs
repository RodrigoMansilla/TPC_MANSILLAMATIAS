using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using AceesoDatos;

namespace AppWeb
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "" || txtpass.Text == "")
            {
                Response.Write("<script>window.alert('Completa los campos down');</script>");
                txtUsuario.Text = "";
                txtpass.Text = "";
                return;
            }
            UsuarioNegocio negocio = new UsuarioNegocio();
            var validar = negocio.LoginUser(txtUsuario.Text, txtpass.Text);
            if (validar == true)
            {

                Response.Redirect("~/DatosClientes.aspx");

            }
            else
            {
                Response.Write("<script>window.alert('datos invalidos');</script>");
                txtUsuario.Text = "";
                txtpass.Text = "";

            }
        }
    }
}