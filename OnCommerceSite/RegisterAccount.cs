using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace OnCommerceSite
{
    public class RegisterAccount : POBase
    {
        public RegisterAccount(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver.FindElement(By.XPath("//form[@action = '/Login/RegisterAccount']")), this);
        }

        public void Refresh()
        {
            PageFactory.InitElements(driver.FindElement(By.XPath("//form[@action = '/Login/RegisterAccount']")), this);
        }

        public void EnterAccountInfo()
        {
            _Email.SendKeys("b@aaa.com");
            _Password.SendKeys("Ntdung@1979");
            _Password2.SendKeys("Ntdung@1979");
            _FirstName.SendKeys("Dung");
            _LastName.SendKeys("Nguyen");

            _Line1.SendKeys("Anc Def");
            _ZipCode.SendKeys("100000");
            _City.SendKeys("Hanoi");
           
            Helper.SelectOptionByText(_Country, "Viet Nam");
            Refresh();
            _RegionTextBox.Clear();
            _RegionTextBox.SendKeys("Mien Bac");

            _CreateAccountButton.Click();

            Assert.AreEqual(
              "Look what's new this week!",
              _driver.FindElement(By.XPath("//div[@class='quicksilver site-wrapper']//strong")).Text
            );
        }




        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement _Email;

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement _Password;

        [FindsBy(How = How.Id, Using = "Password2")]
        private IWebElement _Password2;

        [FindsBy(How = How.Id, Using = "Address_FirstName")]
        private IWebElement _FirstName;

        [FindsBy(How = How.Id, Using = "Address_LastName")]
        private IWebElement _LastName;

        [FindsBy(How = How.Id, Using = "Address_Line1")]
        private IWebElement _Line1;

        [FindsBy(How = How.Id, Using = "Address_PostalCode")]
        private IWebElement _ZipCode;

        [FindsBy(How = How.Id, Using = "Address_City")]
        private IWebElement _City;

        [FindsBy(How = How.Id, Using = "Address_Region")]
        private IWebElement _RegionSelectList;

        [FindsBy(How = How.Id, Using = "Region")]
        private IWebElement _RegionTextBox;

        [FindsBy(How = How.Id, Using = "Address_CountryCode")]
        private IWebElement _Country;

        [FindsBy(How = How.TagName, Using = "button")]
        private IWebElement _CreateAccountButton;

    }
}
