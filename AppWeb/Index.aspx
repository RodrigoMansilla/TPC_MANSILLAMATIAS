<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AppWeb.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0"/>
    
    <title>Log In</title>
       <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

    <script src="Scripts/miLibreriaJS.js"></script>

    <link href="https://fonts.googleapis.com/css?family=Mandali&display=swap" rel="stylesheet">
</head>
<body class="ss">
    <style>         
        div{
     background-color: #FFFFE0;
    border-radius: 5px;
    border: 1px solid #000000;       
    padding: 20px;
    width: 203px;
    position: absolute;
    top: 50%;
    left:50%;    
    transform: translate(-50,-50);
     text-align: center;
        }
        div.center {
  text-align: center;
}
    </style>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="USUARIO:" BackColor="#ffffbf" ></asp:Label> <%--LABEL USUARIO--%>
             <br />
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox> <%--TXTUSUARIO--%>
            <br />
            &nbsp;<asp:Label ID="Label2" runat="server" Text="CONTRASEÑA :" BackColor="#ffffbf" ></asp:Label> <%--LABEL CONTRASEÑA--%>
             <br />
            <asp:TextBox ID="txtpass" runat="server"></asp:TextBox> <%--TXTCONTRASEÑA--%>
            <br />
              
            <asp:Button ID="btnAceptar" runat="server" OnClick="Button1_Click" Text="ACEPTAR" class="btn btn-warning"  visible="false"/> <%--BOTON ACEPTAR--%>
            <br />

        </div>
    </form>
</body>
</html>
