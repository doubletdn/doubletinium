using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using doubletinium.Factory;

namespace doubletinium.Common
{
    public static class Action
    {
        public static void JsClickOn(this IWebElement element)
        {
            string js = "arguments[0].click();";
            ((IJavaScriptExecutor)BrowserFactory.Driver).ExecuteScript(js, element);
        }

        public static void EnterText(this IWebElement element, string value)
        //action EnterText
        {
            //clear exist value
            element.Clear();
            //enter values
            element.SendKeys(value);
        }

        public static void ClickOn(this IWebElement element)
        {
            Actions action = new Actions(BrowserFactory.Driver);
            action.Click(element).Perform();
        }

        public static void DoubleClick(this IWebElement element)
        {
            Actions action = new Actions(BrowserFactory.Driver);
            action.DoubleClick(element).Perform();
        }

        public static void RightClick(this IWebElement element)
        {
            Actions action = new Actions(BrowserFactory.Driver);
            action.ContextClick(element).Perform();
        }

        public static void Set(this IWebElement element, string state)
        {
            if (state.ToLower().Trim() == "on")
            {
                if (!element.IsSelected())
                    element.Click();
            }
            else if (state.ToLower().Trim() == "off")
            {
                if (element.IsSelected())
                    element.Click();
            }
            else throw new FormatException("Should input state is \'on\' or \'off\'");
        }

        public static void ScrollToView(this IWebElement element)
        {
            int elementPosition = element.Location.Y;
            String js = String.Format("window.scroll(0,{0})", elementPosition);
            ((IJavaScriptExecutor)BrowserFactory.Driver).ExecuteScript(js);
        }

        public static bool IsDisplayed(this IWebElement element)
        {
            bool result;

            try
            {
                result = element.Displayed;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public static bool IsSelected(this IWebElement element)
        {
            bool result;

            try
            {
                result = element.Selected;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
        public static void SelectByText(this IWebElement element, string text)
        {
            SelectElement oSelect = new SelectElement(element);
            oSelect.SelectByText(text);
        }
    }
}
