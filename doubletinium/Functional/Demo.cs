using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using doubletinium.Common;

namespace doubletinium.Functional
{
    class Demo
    {
        IWebDriver driver;
        string web_url = "http://demoqa.com/frames-and-windows/";

        [SetUp]
        public void InitTest()
        {
            driver = new ChromeDriver(Settings.DRIVER_DIR);
        }

        [Test]
        public void OpenTest()
        {
            driver.Url = web_url;
            driver.FindElement(By.XPath("//a[@id='ui-id-3']")).Click();
        }

        [TearDown]
        public void CleaningUp()
        {
            driver.Close();
        }

    }
}
