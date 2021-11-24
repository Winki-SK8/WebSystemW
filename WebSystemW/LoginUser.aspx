<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginUser.aspx.cs" Inherits="WebSystemW.LoginUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <!--Bootstrap-->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.0.0.js"></script>
    <!--css-->
    <link href="style/estilo.css" rel="stylesheet" type="text/css" />
    <title>Login</title>
</head>
<body>
    <div class="modal-dialog text-center">
        <div class="col-sm-8 main-section">
            <div class="modal-content">
                <div class="col-12 user-img">
                    <img src="imag/user.png" alt="Alternate Text" />                   
                </div>
                <form class="col-12" runat="server">
                      <div class="form-group tx" id="user-group">
                          <asp:TextBox runat="server" ID="txtNombre" Type="text" CssClass="form-control" placeholder="Nombre de Usuario"></asp:TextBox>
                      </div>
                      <div class="form-group tx" id="contraseña-group">
                          <asp:TextBox runat="server" ID="txtPass" Type="password" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
                          <asp:Label ID="lblError" runat="server" CssClass="text-danger" Text="Password o Usuario incorrecto"></asp:Label>
                      </div>
                      <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-primary col-6" />                  
                </form>
                <div class="col-12 forgot">
                    <a href="https://localhost:44311/RecoverPassword.aspx">Recordar contraseña?</a>
                    <br />
                </div>
            </div>
        </div>
    </div>
</body>
</html>
