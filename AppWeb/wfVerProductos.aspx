<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfVerProductos.aspx.cs" Inherits="AppWeb.wfVerProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Productos</title>
      <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

    <script src="Scripts/miLibreriaJS.js"></script>

    <link href="https://fonts.googleapis.com/css?family=Mandali&display=swap" rel="stylesheet">
     <link href="Estilos.css" rel="stylesheet" type="text/css">


    <style type="text/css">
        .auto-style2 {
            width: 256px;
            border-style: double;
            height: 961px;
        }
        .auto-style3 {
            width: 364px;
            height: 961px;
        }
        .auto-style5 {
            height: 961px;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
           
            <table>
                <tr>
                    <td class="auto-style5">
                     <asp:GridView ID="gvProductos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCreated="gvProductos_RowCreated" HorizontalAlign="Justify">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" BorderColor="Yellow" HorizontalAlign="Center" VerticalAlign="Top" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
                     </td>
        <td class="auto-style5">
                <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:TreeView ID="TreeViewProductos" runat="server" OnSelectedNodeChanged="TreeViewProductos_SelectedNodeChanged" ImageSet="BulletedList2" ShowExpandCollapse="False">
                <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
         
            <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
                </div>
            </td>
                              
               <td class="auto-style2" >
                   <div style="margin-left: auto; margin-right: auto; text-align: center;">
            <asp:Label ID="lblNombre" runat="server" ForeColor="#0066FF" ></asp:Label> <br />
            <asp:Label ID="lblPrecioVenta" runat="server" ForeColor="#0066FF" ></asp:Label> <br />
            <asp:Label ID="lblStock" runat="server" ForeColor="#0066FF" ></asp:Label> <br />
            <%--<asp:Label ID="lblCantidad" runat="server" TEXT="CANTIDAD"></asp:Label>--%>
                      
                       <asp:DropDownList ID="ComboStock" runat="server"></asp:DropDownList>
                    </div>
                   <br />
                   <br />

                   <asp:Button ID="btnAceptar" runat="server" Text="AGREGAR AL CARRO" OnClick="btnAceptar_Click" visible="false" Height="48px" Width="241px" />
                   </td>
    <td class="auto-style3">
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
        <asp:Button ID="btnVerCarro" runat="server" Text="VER CARRITO DE COMPRAS" class="btn btn-primary" visible="false" OnClick="btnVerCarro_Click" />
            <br />
                        <asp:GridView ID="DVCarrito" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" HorizontalAlign="Justify">
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
            <br />
                        <asp:Label ID="lbltoto" class="form_label_align" runat="server" Text="TOTAL :" visible="false" ToolTip ="tu total caradeverga"></asp:Label>
                        <asp:Label ID="lblNtotal" class='form_label_align' runat="server" Text=""></asp:Label>
            </div>
                            <br />

    </td>
                </1tr>

            </table>
        </div>



    </form>
</body>
</html>
