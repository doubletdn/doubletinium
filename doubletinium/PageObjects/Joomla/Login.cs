using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace doubletinium.PageObjects.Joomla
{
    public class Login
    {
        private IWebDriver driver;

        [FindsBy(How = How.Name, Using = "username")][CacheLookup]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "passwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'login-button')]")]
        public IWebElement Login { get; set; }

        public static void LoginJoomla(string username, string password)
        {
            
        }
    }

}
