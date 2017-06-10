using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace doubletinium.PageObjects.Joomla
{
    public class ControlPanelPage
    {
        [FindsBy(How = How.XPath, Using = "//div[h2[.='Logged-in Users']]//strong/a")]
        private IWebElement LoggedinUser { get; set; }

        public string GetLoggedInUsername()
        {
            return LoggedinUser.Text;
        }
    }
}
