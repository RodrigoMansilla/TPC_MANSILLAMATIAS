using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common.Cache;

namespace AppWeb
{
    public partial class datoscostumer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNombre.Text = UserLoginCache.Nombre + ", " + UserLoginCache.Apellido;
            lblCargo.Text = UserLoginCache.Cargo;
            lblCorreo.Text = UserLoginCache.Correo;
        }

        protected void btnVerProductos_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/wfVerProductos.aspx");
        }
    }
}