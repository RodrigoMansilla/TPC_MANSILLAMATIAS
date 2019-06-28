using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace AppWeb
{
    public partial class lista : System.Web.UI.Page
    {
        string conection = @"data source= localhost\\SQLEXPRESS; initial catalog=MansillaRodrigo_DB; integrated security=sspi";

        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon  = new SqlConnection(conection))
            {
                sqlCon.Open();
                SqlDataAdapter SqlAdap = new SqlDataAdapter("select *from productos", sqlCon);
                DataTable dt = new DataTable();
                SqlAdap.Fill(dt);
            }
        }
    }
}