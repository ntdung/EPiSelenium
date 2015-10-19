using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;

namespace OnCommerceSite
{
    [TestFixture()]
    class PhantomDemo
    {
        private IWebDriver _driver;

        [TestFixtureSetUp]
        public void FixtureSetup()
        {
            _driver = new ChromeDriver(); //new PhantomJSDriver();
            _driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));
        }

        [TestFixtureTearDown]
        public void FixtureTearDown()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
            }
        }

        [Test()]
        public void TestLogin()
        {
            _driver.Navigate().GoToUrl(
              "http://vnwks53:17000/Login/Index?returnUrl=%2Fen%2F"
            );
            new RegisterAccount(_driver).EnterAccountInfo();

            //var loginForm = _driver.FindElement(By.XPath("//form[@action='/Login/InternalLogin']"));
            //loginForm.FindElement(By.Id("Email")).SendKeys("a@aaa.com");
            //loginForm.FindElement(By.Id("Password")).SendKeys("Ntdung@1979");
            //loginForm.FindElement(By.XPath("button[text()='Login']")).Submit();
            ////_driver.FindElement(By.XPath("//form[@action='/Login/InternalLogin']//input[@id='Email']")).SendKeys("a@aaa.com");
            ////_driver.FindElement(By.XPath("//form[@action='/Login/InternalLogin']//input[@id='Password']")).SendKeys("Ntdung@1979");
            ////_driver.FindElement(By.XPath("//form[@action='/Login/InternalLogin']//button[text()='Login']")).Submit();

            //Assert.AreEqual(
            //  "Look what's new this week!",
            //  _driver.FindElement(By.XPath("//div[@class='quicksilver site-wrapper']//strong")).Text
            //);

        }
    }
}
