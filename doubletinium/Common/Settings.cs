using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace doubletinium.Common
{
    class Settings
    {
        //PROJECT 
        public static string ROOT_DIR
        {
            get
            {
                string solutionName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                string path = AppDomain.CurrentDomain.BaseDirectory;
                return path.Substring(0, path.LastIndexOf(solutionName) + solutionName.Length);
            
            }
        }
        public static string DRIVER_DIR = Path.Combine(ROOT_DIR, "Drivers");

        //AUT 
        public static string AUT_URL = "https://doubletinium.demojoomla.com/administrator/index.php";
        public static string SUPER_ADMIN_ID = "doubletinium";
        public static string SUPER_ADMIN_PASS = "123456";
        public static string SUPER_USER = "DoubleT";
        public static string TEST_USER_ID = "usertesting";
        public static string TEST_USER_PASS = "test123456";

    }
}