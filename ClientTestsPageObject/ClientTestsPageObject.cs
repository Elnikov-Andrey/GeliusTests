using ClientTestsPageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace ClientTests
{
    public class Tests
    {
        private IWebDriver _webDriver;

        public By _buttonName = By.XPath("//a[@href='/orders/newOrder']");
        public const string buttonName = "Новый заказ";
        public string name = "Новая техкарта №";

        [SetUp]
        public void Setup()
        {
            _webDriver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl("https://rc.gelius.dp.ua/login");
        }

        [Test]
        public void ClientEnterSystem()
        {
            var loginPage = new LoginPageObject(_webDriver);
            loginPage.LoginIn();

            var mainPage = new MainPageObject(_webDriver);
            string userLoginOnMainPage = mainPage.GetUserLoginOnMainPage();
           
            Assert.AreEqual(BaseSettings.clientName, userLoginOnMainPage);
        }

        [Test]
        public void GetName()
        {
            var loginPage = new LoginPageObject(_webDriver);
            loginPage.LoginIn();

            var mainPage = new MainPageObject(_webDriver);
            mainPage.openNewTdsPage();

            var newtdsPage = new NewTDSPageObject(_webDriver);
            string nn = newtdsPage.GetName();

            Assert.AreEqual(nn, name);
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Close();
        }
    }
}