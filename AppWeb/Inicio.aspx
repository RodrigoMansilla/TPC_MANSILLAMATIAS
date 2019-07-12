<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="AppWeb.Inicio" %>
 
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        div {
  width: 400px;
  margin: 0 auto;
}
    </style>

     <div>
            <asp:Label ID="Label1" runat="server" Text="USUARIO:" BackColor="#ffffbf" ></asp:Label> <%--LABEL USUARIO--%>
             <br />
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox> <%--TXTUSUARIO--%>
            <br />
            &nbsp;<asp:Label ID="Label2" runat="server" Text="CONTRASEÑA :" BackColor="#ffffbf" ></asp:Label> <%--LABEL CONTRASEÑA--%>
             <br />
            <asp:TextBox ID="txtpass" runat="server"></asp:TextBox> <%--TXTCONTRASEÑA--%>
            <br />
              
            <asp:Button ID="btnAceptar" runat="server" OnClick="Button1_Click" Text="ACEPTAR" class="btn btn-warning"  /> <%--BOTON ACEPTAR--%>
            <br />

        </div>

</asp:Content>
