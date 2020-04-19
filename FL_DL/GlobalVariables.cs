using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_DL
{


    public class GlobalVariables
    {


        public static string ssCompanyName = "Cafe Management System By FL";
        public static string sCompanyAddress = "CompanyAddress";
        public static string sCompanyLogoPath = Path.Combine(Application.StartupPath, "FL_Logo.gif");
        

        public static string sAppVersion = "1.1.2";
        public static string sMessageBox = "[ Cafe Management System Version : " + sAppVersion + " ]";


        public static string ApplicationDateTimePattern = "dd-MMM-yyyy";
        
        
        //public static string ApplicationDateTimePattern = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
    }
}
