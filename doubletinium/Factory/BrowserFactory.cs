using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.PageObjects;
using doubletinium.Common;

namespace doubletinium.Factory
{
    public class BrowserFactory
    {
        private static readonly Dictionary<string, IWebDriver> Drivers = new Dictionary<string, IWebDriver>();
        private static IWebDriver driver;
        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                    throw new EntryPointNotFoundException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                return driver;
            }
            set { driver = value; }
        }

        public static void InitDriver(string browserName)
        //init driver based on browserName and store in Dictionary Drivers
        {
            switch (browserName.ToLower())
            {
                case "firefox":
                    if (driver == null)
                    {
                        Driver = new FirefoxDriver();
                        Drivers.Add("firefox", Driver);
                    }
                    break;
                case "chrome":
                    if (driver == null)
                    {
                        Driver = new ChromeDriver(Settings.DRIVER_DIR);
                        Drivers.Add("chrome", Driver);
                    }
                    break;
                case "ie":
                    if (driver == null)
                    {
                        Driver = new InternetExplorerDriver(Settings.DRIVER_DIR);
                        Drivers.Add("ie", Driver);
                    }
                    break;
            }
        }

        public static void OpenAUT(string autUrl)
        //open browser and navigating to AUT
        {
            Driver.Url = autUrl;
            Driver.Manage().Window.Maximize();
        } 

        public static void closeAUT()
        //close all drivers and quit browsers
        {
            foreach (var key in Drivers.Keys)
            {
                Drivers[key].Close();
                Drivers[key].Quit();
            }
        }

    }
}
