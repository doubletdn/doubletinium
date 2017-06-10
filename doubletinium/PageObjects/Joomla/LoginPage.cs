using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace doubletinium.PageObjects.Joomla
{
    public class LoginPage
    {
        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "passwd")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(@class,'login-button')]")]
        private IWebElement Login { get; set; }

        public void LoginJoomla(string username, string password)
        {
            UserName.SendKeys(username);
            Password.SendKeys(password);
            Login.Click();
        }

    }

}
