using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectST
{
    class NavBar : BasePage
    {

        public static void  Login(string path1 , string username , string password, string path2)
        {
            driver.FindElement(By.Id(path1)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("loginusername")).SendKeys(username);
            driver.FindElement(By.Id("loginpassword")).SendKeys(password);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(path2)).Click();
            Thread.Sleep(2000);
        }

        public static void loginC(string path)
        {
            //testing close button fuctionality in Login form
            driver.FindElement(By.Id("login2")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(path)).Click();
            Thread.Sleep(2000);
        }

        public static void Loginneg(string username , string password, string path)
        {
            driver.FindElement(By.Id("login2")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("loginusername")).SendKeys(username);
            driver.FindElement(By.Id("loginpassword")).SendKeys(password);
            driver.FindElement(By.XPath(path)).Click();
            Thread.Sleep(2000);
        }
        public static void signupUser(string username, string password,string path)
        {
            driver.FindElement(By.Id("signin2")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("sign-username")).SendKeys(username);
            driver.FindElement(By.Id("sign-password")).SendKeys(password);
            driver.FindElement(By.XPath(path)).Click();
            Thread.Sleep(2000);
        }

        public static void signupClose(string path)
        {
            driver.FindElement(By.Id("signin2")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(path)).Click();
            Thread.Sleep(2000);
        }

        public static void contactForm(string locator, string email,string name, string enterText, string buttonLocator)
        {
            driver.FindElement(By.XPath(locator)).Click(); //locate to contact form page
            Thread.Sleep(2000);
            driver.FindElement(By.Id("recipient-email")).SendKeys(email);
            driver.FindElement(By.Id("recipient-name")).SendKeys(name);
            driver.FindElement(By.Id("message-text")).SendKeys(enterText);
            driver.FindElement(By.XPath(buttonLocator)).Click(); //buttonlocator
            Thread.Sleep(1000);
        }
        public static void contactFormClose(string path)
        {
            driver.FindElement(By.XPath(path)).Click();
            Thread.Sleep(2000);
        }

        public static void aboutUs(string path1,string path2)
        {
            driver.FindElement(By.XPath(path1)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName(path2)).Click();
            Thread.Sleep(2000);
        }

        public static void aboutUsClose(string path1,string path2)
        {
            driver.FindElement(By.XPath(path1)).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(path2)).Click();
            Thread.Sleep(2000);
        }

        public static void home_Return(string path)
        {   
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(path)).Click();
            Thread.Sleep(2000);
        }

        public static void signupFieldEmpty(string username,string password,string path)
        { 
            driver.FindElement(By.Id("signin2")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("sign-username")).SendKeys(username);
            driver.FindElement(By.Id("sign-password")).SendKeys(password);
            driver.FindElement(By.XPath(path)).Click();
            Thread.Sleep(2000);
        }

    }
}
