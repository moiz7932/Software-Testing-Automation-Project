using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectST
{
   public class BasePage
    {
        public static IWebDriver driver { get; set; }
        public IWebDriver SeleniumInitializtion()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }

    }
}
