<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfVerProductos.aspx.cs" Inherits="AppWeb.wfVerProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Productos</title>
     <link href="Estilos.css" rel="stylesheet" type="text/css">
    <style type="text/css">
        .auto-style1 {
            width: 270px;
        }
        .auto-style2 {
            width: 256px;
        }
        .auto-style3 {
            width: 110px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <table>
                <tr>
                    <td>
                     <asp:GridView ID="gvProductos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCreated="gvProductos_RowCreated">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
                     </td>
        <td class="auto-style1">
                
            <asp:TreeView ID="TreeViewProductos" runat="server" OnSelectedNodeChanged="TreeViewProductos_SelectedNodeChanged" ImageSet="BulletedList2" ShowExpandCollapse="False">
                <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
         
            <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
         
            </td>
                              
               <td class="auto-style2">

            <asp:Label ID="lblNombre" runat="server" ></asp:Label> <br />
            <asp:Label ID="lblPrecioVenta" runat="server" ></asp:Label> <br />
            <asp:Label ID="lblStock" runat="server" ></asp:Label> <br />
            <%--<asp:Label ID="lblCantidad" runat="server" TEXT="CANTIDAD"></asp:Label>--%>

            
            <asp:TextBox ID="txtcantidad" runat="server" placeholder="CANTIDAD" ></asp:TextBox>
                   <asp:RequiredFieldValidator ID="mreqEmail" runat="server" ControlToValidate="txtcantidad" ErrorMessage="*" Display="Dynamic" Forecolor="red" ></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="mregEmail" runat="server" ControlToValidate="txtcantidad" ErrorMessage="INTRODUZCA UN NUMERO" ValidationExpression="^\d+$" Display="Dynamic" Forecolor="red"></asp:RegularExpressionValidator>    

                   <asp:Button ID="btnAceptar" runat="server" Text="AGREGAR AL CARRO" OnClick="btnAceptar_Click" />
                   </td>
    <td class="auto-style3">
        <asp:Button ID="btnVerCarro" runat="server" Text="VER CARRITO DE COMPRAS" OnClick="btnVerCarro_Click" />

    </td>
                    <td>
                        <asp:GridView ID="DVCarrito" runat="server"></asp:GridView>
                        </td>
                </1tr>

            </table>
        </div>



    </form>
</body>
</html>
