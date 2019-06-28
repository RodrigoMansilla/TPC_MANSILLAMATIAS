<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datoscostumer.aspx.cs" Inherits="AppWeb.datoscostumer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Bienvenido</title>
    <link href="Estilos.css" rel="stylesheet" type="text/css">
</head>
<body>
    <style> 
        p {
  font-family: monospace;
}
   
    </style>

    <form id="form1" runat="server">
        <div class="hola" contenteditable="false">
        <br />  
        <p>Bienvenido  <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label></p>
        <br />  
        <p>Su cargo actual es : <asp:Label ID="lblCargo" runat="server" Text=""></asp:Label></p>
        <br />  
        <p> Su correo electronico : <asp:Label ID="lblCorreo" runat="server" Text=""></asp:Label></p>
        <br />   
            </div>
        <asp:Button ID="btnVerProductos" runat="server" Height="73px" Text="Ver Productos" Width="324px" OnClick="btnVerProductos_Click" />
    </form>

</body>
</html>
