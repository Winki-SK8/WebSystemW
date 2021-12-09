using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Forms;
using WebSystemW.Class;

namespace WebSystemW
{
    public partial class LoginUser : System.Web.UI.Page
    {
        #region Variables
        
        #endregion
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            //Datos de inicio de sesion
            Session["oUser"] = null;
            Session["oPass"] = null;

            //Datos de inicio de sesion
            if (IsPostBack == false)
            {
                Session["oUser"] = null;
                Session["oPass"] = null;
                Inhabilitar();
            }
            else
            {

            }
        }
        //Se encuentra todo lo que va cargar al inicio de cargar la pagina
        private void ConfiguraPagina()
        {
            
        }
        //Evento boton Ingresar
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtExiste = Login_M.Ingresar(txtNombre.Text,txtPass.Text);

                if (dtExiste.Rows.Count > 0)
                {
                    Session["oUser"] = txtNombre.Text;
                    Session["oPass"] = txtPass.Text;

                    if (chkRecordar.Checked)
                    {
                        HttpCookie cookie = new HttpCookie("TokenP", txtPass.Text);
                        cookie.Expires = DateTime.Now.AddDays(1);
                        this.Response.Cookies.Add(cookie);
                        HttpCookie cookies = new HttpCookie("TokenN", txtNombre.Text);
                        cookies.Expires = DateTime.Now.AddDays(1);
                        this.Response.Cookies.Add(cookies);
                    }
                    else
                    {
                        HttpCookie cookie = new HttpCookie("TokenP", txtPass.Text);
                        cookie.Expires = DateTime.Now.AddDays(-1);
                        this.Response.Cookies.Add(cookie);
                        HttpCookie cookies = new HttpCookie("TokenN", txtNombre.Text);
                        cookies.Expires = DateTime.Now.AddDays(-1);
                        this.Response.Cookies.Add(cookies);

                    }

                    Response.Redirect("Menu.aspx");

                }
                else
                {
                    //Mensaje de error al ingresar
                    ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "invocarfuncion", "Ingresar()", true);
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception source ", ex.Source);
            }
        }
        #endregion
        #region Funciones
        //Ocultar objetos al iniciar
        private void Inhabilitar()
        {
            
        }
        #endregion
    }
}