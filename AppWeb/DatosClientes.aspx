<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DatosClientes.aspx.cs" Inherits="AppWeb.DatosClientes" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <style>
        div {
  width: 400px;
  margin: 0 auto;
}

    </style>


    <div class="hola">
        <br />  
        <p>Bienvenido  <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label></p>
        <br />  
        <p>Su cargo actual es : <asp:Label ID="lblCargo" runat="server" Text=""></asp:Label></p>
        <br />  
        <p> Su correo electronico : <asp:Label ID="lblCorreo" runat="server" Text=""></asp:Label></p>
        <br />   
            </div>
        <asp:Button ID="btnVerProductos" runat="server" Height="73px" Text="Ver Productos" Width="324px" OnClick="btnVerProductos_Click" />
</asp:Content>
