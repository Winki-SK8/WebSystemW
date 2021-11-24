using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace WebSystemW.Class
{
    public class Login
    {
        #region"Variables"
        private string sID_User;
        private string sRecovery_Code;
        private string sPassword;
        private StringBuilder sConsulta;
        private Conexion oConexion;

        #endregion

        #region "Propiedades"
        public string ID_User
        {
            get
            {
                return sID_User;
            }
            set
            {
                sID_User = value;
            }
        }
        public string Recovery_Code
        {
            get
            {
                return sRecovery_Code;
            }
            set
            {
                sRecovery_Code = value;
            }
        }
        public string Password
        {
            get
            {
                return sPassword;
            }
            set
            {
                sPassword = value;
            }
        }
        #endregion

        #region "Construtores"
        public Login()
        {
            sID_User = General.GeneraNewId(0);
        }

        public Login(String _sID_User)
        {
            sID_User = _sID_User;
            RecuperaLogin();
        }
        #endregion

        #region "Funciones"
        public void RecuperaLogin()
        {
            sConsulta = new StringBuilder();
            sConsulta.AppendLine("select *");
            sConsulta.AppendLine("from LOGIN as L");
            sConsulta.AppendLine("inner join User as U on L.ID_User = U.ID_User");
            sConsulta.AppendLine("where U.ID_User ='" + sID_User + "' AND U.Password = '" + sPassword + "' ");

            DataTable dtLogin = Conexion.EjecutarConsultaDatatable(sConsulta.ToString());

            if (dtLogin.Rows.Count != 0)
            {
                sRecovery_Code = dtLogin.Rows[0]["Recovery_Code"].ToString();
                sPassword = dtLogin.Rows[0]["Password"].ToString();

                ObtieneLogin();

            }
        }
        public static DataTable ObtieneLogin()
        {
            StringBuilder sConsulta = new StringBuilder();

            sConsulta.AppendLine("select *");
            sConsulta.AppendLine("from LOGIN as L");
            sConsulta.AppendLine("inner join User as U on L.ID_User = U.ID_User");

            DataTable dtLogin = Conexion.EjecutarConsultaDatatable(sConsulta.ToString());

            return dtLogin;
        }

        #endregion
    }
}