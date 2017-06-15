using System;
using TechTalk.SpecFlow;
using doubletinium.Common;
using doubletinium.Factory;
using doubletinium.PageObjects.Joomla;

namespace doubletinium.FeatureSteps
{
    [Binding]
    public class LoginToJoomla_Steps
    {
        [Given(@"User navigate to Joomla administrator page")]
        public void GivenUserNavigateToJoomlaAdministratorPage()
        {
            BrowserFactory.InitDriver(Settings.BROWSER);
            BrowserFactory.OpenAUT(Settings.AUT_URL);
        }
        
        [When(@"User enter valid (.*) and valid (.*)")]
        public void WhenUserEnterValidAndValid(string username, string password)
        {
            Page.Login.LoginJoomla(username, password);
        }
        
        [Then(@"User login to Joomla administrator page successfully")]
        public void ThenUserLoginToJoomlaAdministratorPageSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Control Panel page display as default")]
        public void ThenControlPanelPageDisplayAsDefault()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
