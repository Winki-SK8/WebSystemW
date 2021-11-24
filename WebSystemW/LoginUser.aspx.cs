using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSystemW
{
    public partial class LoginUser : System.Web.UI.Page
    {
        #region Variables

        #endregion
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            Inhabilitar();
        }
        #endregion
        #region Funciones
        //Ocultar objetos al iniciar
        private void Inhabilitar()
        {
            lblError.Visible = false;
            //lblError.Attributes.Add("style", "visibility:hidden;");
        }
        #endregion
    }
}