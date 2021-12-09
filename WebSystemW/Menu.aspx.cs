using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSystemW
{
    public partial class Menu : System.Web.UI.Page
    {
        #region Variables

        #endregion
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["oUser"] != null)
                {
                    string User = Session["oUser"].ToString();
                    lblUser.Text = User;
                }
                else
                {
                    Response.Redirect("LoginUser.aspx");
                }
            }
            catch
            {
                lblUser.Text = "no existe";
            }
            
        }
        #endregion
        #region Funciones
        //Ocultar objetos al iniciar
        private void Inhabilitar()
        {
            //lblError.Attributes.Add("style", "visibility:hidden;");
        }
        #endregion
    }
}