using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;
using System.Net.Mail;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Threading.Tasks;

namespace WebSystemW.Class
{
    public class General
    {
        #region Funciones
        public static String GeneraNewId(int pvSemilla)
        {
            string vcFechaHora = DateTime.Now.ToString("yyyyMMddHHmmssff");
            int vcSemilla = 0;

            string vlDateTime;
            decimal vlNumeric;
            string vlString;
            string vlString1;
            string vlTimeNow = "";
            string vlKey;
            string vlBase = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ+";
            int vlModulo;

            if ((vcFechaHora == null))
            {
                vcFechaHora = DateTime.Now.ToString("yyyyMMddHHmmssff");
            }

            vlDateTime = vcFechaHora;
            vlNumeric = Convert.ToInt64(vlDateTime);
            vlNumeric = vlNumeric - 1899000000000000;
            vlDateTime = Convert.ToString(vlNumeric);
            vlDateTime = vlDateTime.Substring(1, 13);

            vlNumeric = DateTime.Now.Hour;
            vlNumeric = vlNumeric + 100;
            vlString = Convert.ToString(vlNumeric);
            vlTimeNow = vlTimeNow + vlString.Substring(1);

            vlNumeric = DateTime.Now.Minute;
            vlNumeric = vlNumeric + 100;
            vlString = Convert.ToString(vlNumeric);
            vlTimeNow = vlTimeNow + vlString.Substring(1);

            vlNumeric = DateTime.Now.Second;
            vlNumeric = vlNumeric + 100;
            vlString = Convert.ToString(vlNumeric);
            vlTimeNow = vlTimeNow + vlString.Substring(1);

            vlNumeric = DateTime.Now.Millisecond;
            vlNumeric = vlNumeric + 1000;
            vlString = Convert.ToString(vlNumeric);
            vlTimeNow = vlTimeNow + vlString.Substring(1, 2);

            vlNumeric = vcSemilla;
            vlNumeric = vlNumeric + 100;
            vlString = Convert.ToString(vlNumeric);
            vlKey = vlDateTime + vlTimeNow + vlString.Substring(1);
            if (vcSemilla == 99)
            {
                vcSemilla = 0;
            }
            else
            {
                vcSemilla = vcSemilla + 1;
            }

            vlNumeric = decimal.Parse(vlKey);
            vlString = "";

            while (vlNumeric > 0)
            {
                vlModulo = int.Parse(((vlNumeric % 36) + 1).ToString());
                vlNumeric = vlNumeric / 36;
                //vlNumeric = Convert.ToInt32(vlNumeric);
                if (vlNumeric.ToString().IndexOf(".") > 0)
                {
                    vlNumeric = Convert.ToDecimal(vlNumeric.ToString().Substring(0, vlNumeric.ToString().IndexOf(".")));
                }
                else
                {
                    vlNumeric = Convert.ToDecimal(vlNumeric.ToString());
                }
                vlString1 = vlBase.Substring(vlModulo, 1);
                vlString = vlString1 + vlString;
            }

            System.Threading.Thread.Sleep(500);
            vlString = vlString.Replace("+", "A");
            return vlString;
        }

        #endregion
    }
}