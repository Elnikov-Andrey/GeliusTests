using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientTestsPageObject
{
    class MainPageObject
    {
        private IWebDriver _webDriver;
        private readonly By _userLoginOnMainPage = By.XPath("//*[@id='logout-form']/h2/b");
        private readonly By _newtdsPageButton = By.XPath("/html/body/div/div[2]/div[2]/div[2]/div/div/a[4]");

        public MainPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public string GetUserLoginOnMainPage()
        {
            string userLogin = _webDriver.FindElement(_userLoginOnMainPage).Text;
            return userLogin;
        }

        public NewTDSPageObject openNewTdsPage()
        {
            _webDriver.FindElement(_newtdsPageButton).Click();
            return new NewTDSPageObject(_webDriver);
        }
    }
}
