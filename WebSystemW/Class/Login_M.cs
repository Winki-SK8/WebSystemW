using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace WebSystemW.Class
{
    public class Login_M
    {
        #region"Variables"
        private string sID_User_M;
        private string sPermission;
        private string sRecovery_Code;
        private string sPassword;
        private StringBuilder sConsulta;
        private Conexion oConexion;

        #endregion

        #region "Propiedades"
        public string ID_User_M
        {
            get
            {
                return sID_User_M;
            }
            set
            {
                sID_User_M = value;
            }
        }
        public string Permission
        {
            get
            {
                return sPermission;
            }
            set
            {
                sPermission = value;
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
        public Login_M()
        {
            sID_User_M = General.GeneraNewId(0);
        }

        public Login_M(String _sID_User)
        {
            sID_User_M = _sID_User;
            RecuperaLogin();
        }
        #endregion

        #region "Funciones"

        public void RecuperaLogin()
        {
            sConsulta = new StringBuilder();
            sConsulta.AppendLine("select *");
            sConsulta.AppendLine("from USER_MASTER as UM");
            sConsulta.AppendLine("inner join USER_CONTROL as U on UM.ID_User_M = U.ID_User");
            sConsulta.AppendLine("where U.ID_User ='" + sID_User_M + "' AND U.Password = '" + sPassword + "' ");

            DataTable dtLogin = Conexion.EjecutarConsultaDatatable(sConsulta.ToString());

            if (dtLogin.Rows.Count != 0)
            {
                sPermission = dtLogin.Rows[0]["Permission"].ToString();
                sRecovery_Code = dtLogin.Rows[0]["Recovery_Code"].ToString();
                sPassword = dtLogin.Rows[0]["Password"].ToString();

            }
        }
        //Metodo para Ingresar como Master a la app
        public static DataTable Ingresar(String User, String Pass)
        {
            StringBuilder sConsulta = new StringBuilder();
            sConsulta.AppendLine("select *");
            sConsulta.AppendLine("from USER_MASTER as UM");
            sConsulta.AppendLine("inner join USER_CONTROL as U ON UM.ID_User_M = U.ID_User");
            sConsulta.AppendLine("Where UM.ID_User_M ='" + User + "' and U.Password ='" + Pass + "'");

            DataTable dt = Conexion.EjecutarConsultaDatatable(sConsulta.ToString());
            return dt;
        }

        #endregion
    }
}