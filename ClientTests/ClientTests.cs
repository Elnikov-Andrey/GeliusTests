using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace ClientTests
{
    public class Tests
    {
        IWebDriver driver;
        public By loginInput = By.XPath("//input[@name='username']");
        public By passInput = By.XPath("//input[@name='password']");
        public By loginButton = By.XPath("//button[@type='submit']");
        public By _buttonName = By.XPath("//a[@href='/orders/newOrder']");
        public const string buttonName = "Новый заказ";

        [SetUp]
        public void Setup()
        {
            
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://rc.gelius.dp.ua/login");

        }

        [Test]
        public void ClientEnterSystem()
        {
            driver.FindElement(loginInput).SendKeys("123@i.ua");
            driver.FindElement(passInput).SendKeys("123");
            driver.FindElement(loginButton).Click();
            Thread.Sleep(2000);
            string buttonNameText = driver.FindElement(_buttonName).Text;
            Assert.AreEqual(buttonName, buttonNameText);
        }
        
        [TearDown]
        public void TearDown()
        {
            
            driver.Close();
        }

    }
}