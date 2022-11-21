using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeProjekat.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrangeProjekat.Page
{
    public class DashboardPage
    {
        private IWebDriver? driver = WebDrivers.Instance;

        public IWebElement UserMenu => driver.FindElement(By.ClassName("oxd-userdropdown-name"));

        public void SelectOption(string text)
        {
            SelectElement element = new SelectElement(driver.FindElement(By.ClassName("oxd-dropdown-menu")));
            element.SelectByText(text);
        }
    }
}
