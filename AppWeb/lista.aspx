<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lista.aspx.cs" Inherits="AppWeb.lista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<%--<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>--%>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gvproductos" runat="server">
                <Columns></Columns>
                <asp:boundfield datafield="Nombre" HeaderText ="Nombre" />
                <asp:boundfield datafield="IdCategoria" HeaderText ="IdCategoria" />
                <asp:boundfield datafield="IdMarca" HeaderText ="IdMarca" />
                <asp:boundfield datafield="Stock" HeaderText ="Stock" />
                <asp:boundfield datafield="StockMinimo" HeaderText ="StockMinimo" />
                <asp:boundfield datafield="PrecioCompra" HeaderText ="PrecioCompra" />
                <asp:boundfield datafield="PrecioVenta" HeaderText ="PrecioVenta" />
                <asp:boundfield datafield="Ganancia" HeaderText ="Ganancia" />
                <asp:boundfield datafield="Estado" HeaderText ="Estado" />
                
            </asp:GridView> 
        </div>
    </form>
</body>
</html>
