<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="fmrCompra.aspx.cs" Inherits="AppWeb.fmrCompra" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <style type="text/css">
        .auto-style2 {
            width: 256px;
            border-style: double;
        }
        .auto-style3 {
            width: 364px;
            border-style: double;
        }
        
    </style>

    <nav class="navbar navbar-expand-lg navbar-light bg-light">
  <a class="navbar-brand" href="#">Inicio</a>  
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>

  <div class="collapse navbar-collapse" id="navbarSupportedContent">
    <ul class="navbar-nav mr-auto">
      <li class="nav-item active">
        <a class="nav-link" href="DatosClientes">inicio <span class="sr-only">(current)</span></a>
      </li>
      <li class="nav-item active">
        <a class="nav-link" href="ListadoCompras">Mis Compras <span class="sr-only">(current)</span></a>
      </li>
    </ul>
  </div>
</nav>
    
    
        <div>
           
            <table>
                <tr>
                    <td>
                     <asp:GridView ID="gvProductos" runat="server" BackColor="#CCCCCC" BorderColor="#666666" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" HorizontalAlign="Justify">
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
        <td>
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
                        <asp:DropDownList ID="ComboStock" runat="server" Visible="false"></asp:DropDownList>
                    </div>
                   <br />
                   <br />
                    
                   <br />
                   <br />

                   <asp:Button ID="btnAceptar" runat="server" Text="AGREGAR AL CARRO" class="btn btn-primary" OnClick="btnAceptar_Click" visible="false" Height="48px" Width="241px" />
                   </td>
    <td class="auto-style3">
        <div style="margin-left: auto; margin-right: auto; text-align: center;">
        <asp:Button ID="btnVerCarro" runat="server" Text="CARRITO DE COMPRAS" class="btn btn-primary" visible="false" OnClick="btnVerCarro_Click" />
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
                        <asp:Label ID="lbltoto" class="form_label_align" runat="server" Text="TOTAL :" visible="False" ToolTip ="tu total caradeverga" Font-Bold="True" Font-Size="Larger" Font-Underline="True"></asp:Label>
                        <asp:Label ID="lblNtotal" class='form_label_align' runat="server" Text="" Font-Underline="true"></asp:Label>
            </div>
                            <br />

    </td>
                </1tr>

            </table>
            <asp:Button ID="btnFinalizarCompra" runat="server" Text="Finalizar la compra" Height="78px" Width="1653px" CssClass="badge-info" OnClick="btnFinalizarCompra_Click" Visible="false"/>
        </div>



    


</asp:Content>
