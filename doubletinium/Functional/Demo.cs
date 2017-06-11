using NUnit.Framework;
using doubletinium.Common;
using doubletinium.Factory;
using doubletinium.PageObjects.Joomla;


namespace doubletinium.Functional
{
    class Demo
    {
        [SetUp]
        public void InitTest()
        {
            BrowserFactory.InitDriver(Settings.BROWSER);
            BrowserFactory.OpenAUT(Settings.AUT_URL);
        }

        [Test]
        public void LoginTest()
        {
            Page.Login.LoginJoomla(Settings.SUPER_ADMIN_ID, Settings.SUPER_ADMIN_PASS);
            Assert.AreEqual(Settings.SUPER_USER, Page.ControlPanel.GetLoggedInUsername());

            Page.ControlPanel.OpenUserTab();
            Page.Users.SelectAllRecords();
        }

        [TearDown]
        public void CleaningUp()
        {
            //BrowserFactory.closeAUT();
        }

    }
}
