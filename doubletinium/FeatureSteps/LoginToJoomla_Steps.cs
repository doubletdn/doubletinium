using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using doubletinium.Common;
using doubletinium.Factory;
using doubletinium.PageObjects.Joomla;
using NUnit.Framework;


namespace doubletinium.FeatureSteps
{
    [Binding]
    public class LoginToJoomla_Steps
    {
        private dynamic userAccount;

        [Given(@"User navigate to Joomla administrator page")]
        public void GivenUserNavigateToJoomlaAdministratorPage()
        {
            BrowserFactory.InitDriver(Settings.BROWSER);
            BrowserFactory.OpenAUT(Settings.AUT_URL);
        }

        [When(@"User login with valid account")]
        public void WhenUserEnterValidAndValid(dynamic table)
        {
            userAccount = table;
            Page.Login.LoginJoomla((string)userAccount.Username, (userAccount.Password).ToString());
        }
        
        [Then(@"User login to Joomla administrator page successfully")]
        public void ThenUserLoginToJoomlaAdministratorPageSuccessfully()
        {
            Assert.AreEqual((string)userAccount.Username, Page.ControlPanel.GetLoggedInUsername());
        }
        
        [Then(@"Control Panel page display as default")]
        public void ThenControlPanelPageDisplayAsDefault()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
