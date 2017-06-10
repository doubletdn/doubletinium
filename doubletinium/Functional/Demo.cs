using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using doubletinium.Common;
using doubletinium.PageObjects.Joomla;

namespace doubletinium.Functional
{
    class Demo
    {
        IWebDriver driver;

        [SetUp]
        public void InitTest()
        {
            driver = new ChromeDriver(Settings.DRIVER_DIR);
            driver.Url = Settings.AUT_URL;
        }

        [Test]
        public void OpenTest()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginJoomla(Settings.SUPER_ADMIN_ID, Settings.SUPER_ADMIN_PASS);
            var controlPanelPage = new ControlPanelPage(driver);
            Assert.AreEqual(Settings.SUPER_USER, controlPanelPage.GetLoggedInUsername());

        }

        [TearDown]
        public void CleaningUp()
        {
            //driver.Close();
        }

    }
}
