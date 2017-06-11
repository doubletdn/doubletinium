using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using doubletinium.Common;

namespace doubletinium.PageObjects.Joomla
{
    public class ControlPanelPage
    {
        [FindsBy(How = How.XPath, Using = "//div[h2[.='Logged-in Users']]//strong/a")]
        private IWebElement LoggedinUser { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[span[.='Users']]")]
        private IWebElement UserTab { get; set; }

        public string GetLoggedInUsername()
        {
            return LoggedinUser.Text;
        }

        public void OpenUserTab()
        {
            UserTab.ScrollToView();
            UserTab.ClickOn();
        }
    }
}
