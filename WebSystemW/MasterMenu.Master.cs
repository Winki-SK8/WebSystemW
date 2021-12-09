using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSystemW
{
    public partial class MasterMenu : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                //Token para mantener la session abierta
                if (Request.Cookies["Tokenp"] != null && Request.Cookies["TokenN"] != null)
                {
                    Session["oUser"] = Request.Cookies["TokenN"].Value;
                    Session["oPass"] = Request.Cookies["TokenP"].Value;
                    
                }
                //Datos de inicio de sesion del usuario
                if (Session["oUser"] != null && Session["oPass"] != null)
                {

                }
                else
                {
                    Response.Redirect("LoginUser.aspx");
                }
            }
        }
    }
}