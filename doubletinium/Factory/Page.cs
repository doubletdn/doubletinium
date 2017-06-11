using OpenQA.Selenium.Support.PageObjects;
using doubletinium.Factory;
using doubletinium.PageObjects.Joomla;
using System;
using System.Collections.Generic;
using System.Collections;

namespace doubletinium.Factory
{
    public class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(BrowserFactory.Driver, page);
            return page;
        }

        public static LoginPage Login
        {
            get { return GetPage<LoginPage>(); }
        }

        public static ControlPanelPage ControlPanel
        {
            get { return GetPage<ControlPanelPage>(); }
        }

        public static UsersPage Users
        {
            get { return GetPage<UsersPage>(); }
        }
    }
}
