using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientTestsPageObject
{
    class NewTDSPageObject
    {
        private IWebDriver _webDriver;
        private readonly By _name = By.XPath("//*[@id='productHeader']/div[1]/div[1]/div/div[1]/p");

        public NewTDSPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public string GetName()
        {
            string name = _webDriver.FindElement(_name).Text;
            return name;
        }

    }
}
