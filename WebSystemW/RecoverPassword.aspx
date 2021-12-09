<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecoverPassword.aspx.cs" Inherits="WebSystemW.RecoverPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <!--Bootstrap-->
    <link href="Bootstrap4/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Bootstrap4/Scripts/bootstrap.min.js"></script>
    <script src="Bootstrap4/Scripts/jquery-3.0.0.js"></script>
    <!--css-->
    <link href="style/estilo.css" rel="stylesheet" type="text/css" />
    <title>Recover Password</title>
</head>
<body>
    <div class="modal-dialog text-center">
      <div class="col-sm-8 main-section">
         <div class="modal-content">
             <div class="col-12 p-3">
                 <h4 class="text-white"> Recuperación de la cuenta</h4>
                 <asp:Label ID="lblCorreo" CssClass="text-white" runat="server" Text="*******@gmail.com"></asp:Label>
              </div>
              <form class="col-12" runat="server">
                     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <div id="divEnviar" runat="server">
                                    <div class="form-group tx" id="user-group">
                                        <asp:Label ID="Label2" CssClass="text-white" runat="server" Text="Se enviará un código de recuperación a su correo"></asp:Label>
                                    </div>
                                    <div>
                                        <asp:Button ID="btnEnviar" OnClick="btnEnviar_Click" runat="server" Text="Enviar" CssClass="btn btn-primary btnIngresar" />  
                                    </div>
                                </div>                               
                                <div runat="server" class="form-group tx" id="contraseña" style="display:none;">
                                    <asp:TextBox runat="server" ID="txtPass"  Type="password" CssClass="form-control" placeholder="Ingrese código de recuperación"></asp:TextBox>       
                                </div>  
                                <div id="Error" runat="server" style="display: none;">
                                    <asp:Label ID="lblError" runat="server"  CssClass="text-danger" Text="Código incorrecto"></asp:Label>
                                </div>
                                <div id="divduo" runat="server" style="display:none;">
                                    <asp:Button ID="btnReenviar" runat="server" Text="Reenviar"  CssClass="btn btn-secondary btndual" /> 
                                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar"  CssClass="btn btn-primary btndual" />  
                                </div>
                           </ContentTemplate>
                       </asp:UpdatePanel>
                   </form>
               <div class="col-12 forgot">
                  <a href="https://localhost:44311/LoginUser.aspx">Ingresar a cuenta</a>
                  <br />
               </div>
         </div>
      </div>
   </div>
</body>
</html>
