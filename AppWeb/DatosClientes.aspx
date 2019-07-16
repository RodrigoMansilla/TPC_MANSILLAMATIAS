<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DatosClientes.aspx.cs" Inherits="AppWeb.DatosClientes" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <style>
        div {
  width: 400px;
  margin: 0 auto;
}

         .auto-style1 {
             background-color: #b6ff00;
             border-radius: 5px;
             border: 1px solid #000000;
             padding: 20px;
             width: 591px;
             text-align: center;
         }

    </style>

    <table>
        <tr>
            <td colspan="2">
    <div class="auto-style1">
        <br />  
        <p>Bienvenido  <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label></p>
        <br />  
        <p>Su cargo actual es : <asp:Label ID="lblCargo" runat="server" Text=""></asp:Label></p>
        <br />  
        <p> Su correo electronico : <asp:Label ID="lblCorreo" runat="server" Text=""></asp:Label></p>
        <br />   
            </div>
                </td>
            </tr>
        <tr>
            <td>
        <asp:Button ID="btnVerProductos" runat="server" Height="73px" Text="Ver Productos" Width="324px" OnClick="btnVerProductos_Click" />
        </td>
            <td>
                <asp:Button ID="btnVercompras" runat="server" Text="Ver Compras" Height="73px" Width="324px" OnClick="btnVercompras_Click" />
            </td>
                </tr>
            </table>
</asp:Content>
