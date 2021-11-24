using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

namespace WebSystemW
{
    public partial class RecoverPassword : System.Web.UI.Page
    {
        #region Variables
        #endregion
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            Inhabilitar();
        }
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            divduo.Attributes.Add("style", "display: true;");
            divEnviar.Attributes.Add("style", "display: none;");
            contraseña.Attributes.Add("style", "display: true;");
        }
        #endregion
        #region Funciones
        //Ocultar Objetos al iniciar
        private void Inhabilitar()
        {
            
        }
        //Metodo para enviar codigo de recuperacion al correo
        private string sendEmail(string to, string asunto, string body)
        {
            string msge = "Error al enviar este correo.";
            string from = "sistemas_system@hotmail.com";
            string displayName = "soporte WebSystemW";
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(to);
                //mail.CC.Add();  copia
                //mail.Bcc.Add(), copia oculta

                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = false;

                SmtpClient client = new SmtpClient("smtp.office365.com", 587);
                client.Credentials = new NetworkCredential(from, "computadoras19");
                client.EnableSsl = true;

                client.Send(mail);
                msge = "!Correo enviado exitosamente¡";

            }catch(Exception ex)
            {
                msge = ex.Message + "Por favor verifica tu conexion a internet y que tus datos sean correctos e intenta nuevamente.";

            }

            return msge;
        }

        #endregion
    }
}