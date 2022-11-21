using OpenQA.Selenium;
using OrangeProjekat.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeProjekat.Page
{
    public class Login
    {
        private IWebDriver? driver = WebDrivers.Instance;

        public IWebElement UserName => driver.FindElement(By.Name("username"));
        public IWebElement Password => driver.FindElement(By.Name("password"));
        public IWebElement LoginButton => driver.FindElement(By.CssSelector(".orangehrm-login-button"));

        public void LoginUser(string name, string pass)
        {
            UserName.SendKeys(name);
            Password.SendKeys(pass);
            LoginButton.Submit();
        }

    }
    
    
        
    
}
