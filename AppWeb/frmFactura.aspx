<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" EnableEventValidation = "false" CodeBehind="frmFactura.aspx.cs" Inherits="AppWeb.frmFactura" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    


    <style>
        div {
  width: 200px;
  /*margin: 0 auto;*/
}
        .auto-style2 {
            width: 254px;
            height: 21px;
        }
        .auto-style3 {
            width: 230px;
            height: 21px;
        }
        .auto-style4 {
            width: 1056px;
            margin-left: 0px;
            height: 455px;
        }
        .auto-style5 {
            border-style: solid;
            border-color: inherit;
            border-width: medium;
            width: 184px;
            height: 21px;
            vertical-align:middle;
              text-align:center;
        }
        
        .auto-style6 {
            width: 428px;
            height: 21px;
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

     .nuevo{
         text-indent: 40px;
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
        <a class="nav-link" href="fmrCompra">Volver a comprar <span class="sr-only">(current)</span></a>
      </li>
        <li class="nav-item active">
        <a class="nav-link" href="ListadoCompras">Mis compras <span class="sr-only">(current)</span></a>
      </li>
    </ul>
  </div>
</nav>


    <asp:Panel ID="Panel1" runat="server">
    <div class="auto-style4">
        <table border="1" class="auto-style7" id="table1">
            <tbody>
            <tr>
                <td class="auto-style2">
 <asp:Label ID="lblNombreComercio" runat="server" ForeColor="Blue" Text="Pescaderia Tito" Font-Bold="True" Font-Overline="False" BorderColor="Black"  size="5"></asp:Label>
            </td>
                <td class="auto-style3">
                    <br />  
                    
                    <asp:Label ID="lblDireccion" runat="server" Text="Carlos Tejedor 2555 Vicente López"></asp:Label>
                    <br />
                    <asp:Label ID="lblTelefono" runat="server" Text="03327-485432"></asp:Label>
                </td>
                <td class="auto-style5" >
                    
                    <asp:Label ID="lblB" runat="server" Text="B" BorderStyle="Solid" BorderWidth="5px" Height="26px" Width="34px" ></asp:Label>
                   
                </td>
                <td class="auto-style6">

                    <asp:Label ID="lblFacuta" runat="server" Text="FACTURA" Font-Bold="True"></asp:Label>
                   
<%--                   
                    <asp:Label ID="lblOriginal" runat="server" Text="ORIGINAL" display="block"></asp:Label>
                       --%>
                    <div style="text-align:left";>
                    <p>ORIGINAL</p>
                    </div>
                    <asp:Label ID="lblFactura" runat="server" Text="Factura Nº : "></asp:Label>  <asp:Label ID="lblNfactura" runat="server" Text=""></asp:Label>
                        <br />
                    <asp:Label ID="lblFecha" runat="server" Text="Fecha de Emision: "></asp:Label>  <asp:Label ID="lblFechaEmision" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="lblcuit" runat="server" Text="CUIT: "></asp:Label>   <asp:Label ID="lblcuit1" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Label ID="lblInicioActividad" runat="server" Text="Inicio de actividades: "></asp:Label>  <asp:Label ID="lblInicioActividad1" runat="server" Text=""></asp:Label>

                </td>
                    </tr>
                <tr>
                    <td colspan="5" class="ads">
                        <asp:Label ID="lblCliente" runat="server" Text="CLIENTE"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" class="auto-style7">
                        <asp:Label ID="lblNombres" runat="server" Text="NOMBRE Y APELLIDO : "></asp:Label>  <asp:Label ID="lblNombres1" runat="server" class="nuevo" Text=""></asp:Label> <asp:Label ID="lblNombres2" runat="server" Text=""></asp:Label>
                        <br />
                        <asp:Label ID="lblIVA" runat="server" Text="CONDICION FRENTE AL IVA : CONSUMIDOR FINAL."></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:Label ID="lbldni" runat="server" Text="DOCUMENTO  : "></asp:Label>  <asp:Label ID="lbldni1" runat="server" Text=""></asp:Label>
                        <br />
                        <asp:Label ID="lbldirrecion" runat="server" Text="DIRECCION : "></asp:Label>  <asp:Label ID="lbladdres" runat="server" Text=""></asp:Label>
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
                        <asp:Label ID="lblCompleto" runat="server" Text="TOTAL : "></asp:Label> 
                        <asp:Label ID="lblCompleto1" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Button ID="btnExportar" runat="server" Text="Exportar a Pdf" OnClick="btnExportar_Click" Width="1016px" />
                    </td>
                </tr>
                </tbody>
                </table>
            </div>
        </asp:Panel>
        
</asp:Content>
