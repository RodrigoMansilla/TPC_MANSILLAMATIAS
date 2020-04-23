<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="AppWeb.Inicio" %>
 
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>


        div {
  width: 100px;
  margin: 0 auto;
  height:50%;
  text-align: center;
}
        .container {
  position: relative;
  width: 50%;
  display: flex;
justify-content: space-around;
flex-wrap: wrap;
 height:50%;
}

        .image {
  display: block;
  width: 10%;
  height: 10%;
}

.overlay {
  position: absolute;
  bottom: 100%;
  left: 0;
  right: 0;
  background-color: #008CBA;
  overflow: hidden;
  width: 500%;
  height:50%;
  transition: .5s ease;
}
.container:hover .overlay {
  bottom: 0;
  height: 100%;
}
        .auto-style1 {
            height: 939px;
            width: 837px;
        }
    </style>

     <div>
         <div class="container">
  <img src="Imagenes\caja.jpg" class="auto-style1" height="1024" width="720" >
  <div class="overlay">
      <br />
      <br />
      <br />
    <div class="text">  <%--<asp:Label ID="Label1" runat="server" Text="USUARIO:" BackColor="#ffffbf" ></asp:Label> LABEL USUARIO--%>
             <br />
            <asp:TextBox ID="txtUsuario" runat="server" placeholder="Usuario"></asp:TextBox> <%--TXTUSUARIO--%>
            <br />
            &nbsp;<%--<asp:Label ID="Label2" runat="server" Text="CONTRASEÑA:" BackColor="#ffffbf" ></asp:Label> <%--LABEL CONTRASEÑA--%>
             <br />
            <asp:TextBox ID="txtpass" runat="server" placeholder="Contraseña" ></asp:TextBox> <%--TXTCONTRASEÑA--%>
            <br />
              
            <asp:Button ID="btnAceptar" runat="server" OnClick="Button1_Click" Text="ACEPTAR" class="btn btn-warning"  /> <%--BOTON ACEPTAR--%>
            <br /></div>
  </div>
</div>


            

          

        </div>

</asp:Content>
