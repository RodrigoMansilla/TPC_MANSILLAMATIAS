<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmFactura.aspx.cs" Inherits="AppWeb.frmFactura" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        div {
  width: 200px;
  /*margin: 0 auto;*/
}
        .auto-style2 {
            width: 254px;
            height: 116px;
        }
        .auto-style3 {
            width: 230px;
            height: 116px;
        }
        .auto-style4 {
            width: 1056px;
            margin-left: 0px;
            height: 455px;
        }
        .auto-style5 {
            width: 184px;
            height: 116px;
            border:solid;
        }
        
        .auto-style6 {
            width: 428px;
            height: 116px;
        }
        table {
  border: solid;
}
        
        .auto-style7 {
            height: 64px;
        }
        .auto-style8 {
            height: 47px;
        }
        
    </style>

    <div class="auto-style4">
        <table border="1" class="auto-style7">
            <tbody>
            <tr>
                <td class="auto-style2">
 <asp:Label ID="lblNombreComercio" runat="server" Font-Size="XX-Large" ForeColor="Blue" Text="Pescaderia Tito" Font-Bold="True" Font-Overline="False" BorderColor="Black"></asp:Label>
            </td>
                <td class="auto-style3">
                    <br />
                    
                    <asp:Label ID="lblDireccion" runat="server" Text="Carlos Tejedor 2555 Vicente López" Font-Size="Small"></asp:Label>
                    <br />
                    <asp:Label ID="lblTelefono" runat="server" Text="03327-485432" Font-Size="Small"></asp:Label>
                </td>
                <td class
                    ="auto-style5">
                    <%--solo para que quede un espacio --%>
                    &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
                    <asp:Label ID="lblB" runat="server" Text="B" BorderStyle="Solid" BorderWidth="5px" Font-Size="XX-Large"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <br />

                </td>
                <td class="auto-style6">

                    <asp:Label ID="lblFacuta" runat="server" Text="FACTURA" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                    &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
                    <asp:Label ID="lblOriginal" runat="server" Text="ORIGINAL" display="block"></asp:Label>

                    <br />
                    <asp:Label ID="lblFactura" runat="server" Text="Factura Nº : "></asp:Label> &nbsp <asp:Label ID="lblNfactura" runat="server" Text=""></asp:Label>
                        <br />
                    <asp:Label ID="lblFecha" runat="server" Text="Fecha de Emision: "></asp:Label> &nbsp <asp:Label ID="lblFechaEmision" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="lblcuit" runat="server" Text="CUIT: "></asp:Label> &nbsp  <asp:Label ID="lblcuit1" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="lblInicioActividad" runat="server" Text="Inicio de actividades: "></asp:Label> &nbsp <asp:Label ID="lblInicioActividad1" runat="server" Text=""></asp:Label>

                </td>
                    </tr>
                <tr>
                    <td colspan="5" class="ads">
                        <asp:Label ID="lblCliente" runat="server" Text="CLIENTE"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style7">
                        <asp:Label ID="lblNombres" runat="server" Text="NOMBRE Y APELLIDO : "></asp:Label> &nbsp <asp:Label ID="lblNombres1" runat="server" Text=""></asp:Label> &nbsp <asp:Label ID="lblNombres2" runat="server" Text=""></asp:Label>
                        <br />
                        <asp:Label ID="lblIVA" runat="server" Text="CONDICION FRENTE AL IVA : CONSUMIDOR FINAL."></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:Label ID="lbldni" runat="server" Text="DOCUMENTO  : "></asp:Label> &nbsp <asp:Label ID="lbldni1" runat="server" Text=""></asp:Label>
                        <br />
                        <asp:Label ID="lbldirrecion" runat="server" Text="DIRECCION : "></asp:Label> &nbsp <asp:Label ID="lbladdres" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="5">
                       <br />

                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">
                        <asp:Label ID="lblname" runat="server" Text="Nombre"></asp:Label>
                        <br />
                        
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="lblcant" runat="server" Text="Cantidad"></asp:Label>
                        <br />
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="lblprecio" runat="server" Text="Precio"></asp:Label>
                        <br />
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="lblsub" runat="server" Text="Subtotal"></asp:Label>
                        <br />
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:GridView ID="gvName" runat="server" BorderStyle="None" GridLines="None" ShowHeader="False" ></asp:GridView>
                    </td>
                    
                    <td>
                        <asp:GridView ID="Gvcantidad" runat="server" BorderStyle="None" GridLines="None" ShowHeader="False"  ></asp:GridView>
                    </td>
                    
                    <td>
                        <asp:GridView ID="gvPrecio" runat="server" BorderStyle="None" GridLines="None" ShowHeader="False" ></asp:GridView>
                    </td>
                    
                    <td>
                        <asp:GridView ID="gvSubtotal" runat="server" BorderStyle="None" GridLines="None" ShowHeader="False"></asp:GridView>
                    </td>
                </tr>

                <tr>
                    <td colspan="4">
                        <asp:Label ID="lblCompleto" runat="server" Text="TOTAL : "></asp:Label> &nbsp 
                        <asp:Label ID="lblCompleto1" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                </tbody>
                </table>
            </div>
        
</asp:Content>
