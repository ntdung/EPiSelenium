using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OnCommerceSite
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver _driver;

        [TestMethod]
        public void TestMethod1()
        {
            _driver = new ChromeDriver(); //new PhantomJSDriver();
            _driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));

            _driver.Navigate().GoToUrl(
              "http://vnwks53:17000/Login/Index?returnUrl=%2Fen%2F"
            );
            new RegisterAccount(_driver).EnterAccountInfo();


        }
    }
}
