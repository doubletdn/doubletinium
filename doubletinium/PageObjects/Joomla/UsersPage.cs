using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using doubletinium.Common;

namespace doubletinium.PageObjects.Joomla
{
    public class UsersPage
    {

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @name='checkall-toggle']")]
        private IWebElement CheckAllToggle { get; set; }

        public void SelectAllRecords()
        {
            CheckAllToggle.Set("on");
        }
    }
}
