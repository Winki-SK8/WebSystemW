<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginUser.aspx.cs" Inherits="WebSystemW.LoginUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <!--Bootstrap-->
    <link href="Bootstrap4/Content/bootstrap.min.css" rel="stylesheet" />
     <!--css-->
    <link href="style/estilo.css" rel="stylesheet" type="text/css" />
    <!-- Alertify CSS -->
    <link rel="stylesheet" href="plugins/alertifyjs/css/alertify.min.css" />  
	<!-- Alertify theme default -->  
	<link rel="stylesheet" href="plugins/alertifyjs/css/themes/default.min.css"/>  

    <title>Login</title>
</head>
<body>
      <!-- jQuery--> 
    <script src="Bootstrap4/Content/jquery-3.6.0.min.js"></script>
    <!-- Popper.js--> 
    <script src="Bootstrap4/Content/popper.min.js"></script>
    <!-- Bootstrap JS -->  
    <script src="Bootstrap4/Scripts/bootstrap.min.js"></script>
    <!-- Plugin Sweet alert -->  
    <script src="plugins/sweetalert/sweetalert.min.js"></script>  		  
	<!-- Plugins Alertify -->  
    <script src="plugins/alertifyjs/js/alertify.min.js"></script> 

     <script type="text/javascript">
         var xPos, yPos;
         var prm = Sys.WebForms.PageRequestManager.getInstance();
         prm.add_beginRequest(BeginRequestHandler);
         prm.add_endRequest(EndRequestHandler);

         function BeginRequestHandler(sender, args) {
             xPos = $get('scrollDiv').scrollLeft;
             yPos = $get('scrollDiv').scrollTop;
         }

         function EndRequestHandler(sender, args) {
             $get('scrollDiv').scrollLeft = xPos;
             $get('scrollDiv').scrollTop = yPos;
         }        

         //$(document).ready(function () {
         //    InicializarComponentes();
         //});
         //function InicializarComponentes() {    
         //    Ingresar();
         //}
         function Ingresar() {
                 swal("Advertencia", "Usuario o password incorrecto. intente nuevamente", "warning");
                 //swal("Informacion", "..."texto informativo", "success"); //"error"
             }
     </script>
    <div class="modal-dialog text-center">
        <div class="col-sm-8 main-section">
            <div class="modal-content">
                <div class="col-12 user-img">
                    <img src="imag/user.png" alt="Alternate Text" />                   
                </div>
                <form class="col-12" runat="server">
                      <div class="form-group tx" id="user-group" style="margin: auto auto 20px auto">
                          <asp:TextBox runat="server" ID="txtNombre" Type="text" CssClass="form-control" placeholder="Nombre de Usuario"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="rfvNombre" ErrorMessage="Campo obligatorio" CssClass="rfv" ControlToValidate="txtNombre" runat="server" Display="Dynamic"  />
                      </div>
                      <div class="form-group tx" id="contraseña-group" style="margin: auto auto 25px auto">
                          <asp:TextBox runat="server" ID="txtPass" Type="password" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="rfvPass" ErrorMessage="Campo obligatorio" CssClass="rfv" ControlToValidate="txtPass" runat="server" Display="Dynamic"  />
                      </div>
                    <div class="">
                      <label class="form-check-label" style="margin: auto auto 15px auto">
                        <input type="checkbox" runat="server" id="chkRecordar" class="form-check-input" value=""/>Recordar Credenciales
                      </label>
                    </div>
                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn btn-primary col-6" OnClick="btnIngresar_Click" /> 
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
