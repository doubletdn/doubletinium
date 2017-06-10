using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace doubletinium.Common
{
    class ElementDefinition
    {
        public static By Id(string id)
        {
            return By.Id(id);
        }
    }
}
