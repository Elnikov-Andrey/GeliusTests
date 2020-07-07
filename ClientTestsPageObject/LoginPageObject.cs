using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientTestsPageObject
{
    class LoginPageObject
    {
        private IWebDriver _webDriver;
        private readonly By loginInput = By.XPath("//input[@name='username']");
        private readonly By passInput = By.XPath("//input[@name='password']");
        private readonly By loginButton = By.XPath("//button[@type='submit']");

        public LoginPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainPageObject LoginIn()
        {
            _webDriver.FindElement(loginInput).SendKeys(BaseSettings.login);
            _webDriver.FindElement(passInput).SendKeys(BaseSettings.password);
            _webDriver.FindElement(loginButton).Click();
            return new MainPageObject(_webDriver);
        }



    }
}
