using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using doubletinium.Common;



namespace doubletinium
{
    class Program
    {
        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
        static void Main(string[] args)
        {
            //string solutionDirectory = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            //string driverDir = Path.Combine(solutionDirectory, "drivers");
            //string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            //UriBuilder uri = new UriBuilder(codeBase);
            //string path = Uri.UnescapeDataString(uri.Path);
            //string pathFinal = Path.GetDirectoryName(path);
            //string classDir = Settings.ROOT_DIR;

            string assemblyname = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string solutionDir = path.Substring(0, path.LastIndexOf(assemblyname) + assemblyname.Length);
            //string path = AssemblyDirectory;
            //Debug.WriteLine(AssemblyDirectory);

            //bool driverExist = File.Exists(chromeDriver);

            //Debug.WriteLine(driverExist);

            //IWebDriver driver = new ChromeDriver(driverDir);
            //driver.Url = "https://google.com";
            //driver.Navigate();

        }
    }
}
