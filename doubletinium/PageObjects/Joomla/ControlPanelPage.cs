using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace doubletinium.PageObjects.Joomla
{
    public class ControlPanelPage
    {
        private IWebDriver driver;

        public ControlPanelPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[h2[.='Logged-in Users']]//strong/a")]
        private IWebElement LoggedinUser { get; set; }

        public string GetLoggedInUsername()
        {
            return LoggedinUser.Text;
        }
    }
}
