using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace OnCommerceSite
{
    public class RegisterAccount : POBase
    {
        public RegisterAccount(IWebDriver driver)
        {
            this.driver = driver;

        }
    }
}
