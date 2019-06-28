using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

         protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)// datalist1.itemcommand 
         {/*
             string cod, des;
             double pre;
             int can;
             if (e.CommandName == "sekeccionar")
             {
                 DataList1.SelectedIndex = e.Item.ItemIndex;
                 cod = (DataList1.SelectedItem.FindControl("codproductoLabel"), Label).Text
             }
         */}
    }
}