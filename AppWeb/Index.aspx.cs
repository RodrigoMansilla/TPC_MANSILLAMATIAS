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
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogIn(object sender, EventArgs e)
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            var validar = negocio.LoginUser(TextBox1.Text, TextBox2.Text);
            if (validar == true)
            {

                Response.Redirect("~/datoscostumer.aspx");

            }
            else
            {
                //aca decir datos incorrectos 
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            var validar = negocio.LoginUser(TextBox1.Text, TextBox2.Text);
            if (validar == true)
            {

                Response.Redirect("~/datoscostumer.aspx");

            }
            else
            {
                //aca decir datos incorrectos 
            }
        }
    }
}