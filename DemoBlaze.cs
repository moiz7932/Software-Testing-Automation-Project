using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ProjectST
{
    [TestClass]

    public class DemoBlaze : BasePage
    {
        #region setups and cleanups

        public TestContext instance;        //csv file jb external use kr rhy honge for data tou ye default initialize krwana prega
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [AssemblyInitialize()]

        public static void AssemblyInitialize(TestContext context)
        {

        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {

        }

        [ClassInitialize()]

        public static void ClassInit(TestContext context)
        {

        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {

        }

        [TestInitialize()]

        public void TestInit()
        {
           BasePage basePage = new BasePage();
           basePage.SeleniumInitializtion();


            //SeleniumInitializtion();
        }

        [TestCleanup()]

        public void TestCleanup()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();

        }
        #endregion

        [TestMethod, TestCategory("positive")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "Login", DataAccessMethod.Sequential)]
        public void LoginPositive()
        {

            #region
            string path1 = TestContext.DataRow["path1"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string path2 = TestContext.DataRow["locator"].ToString();
            string url = TestContext.DataRow["url"].ToString();
            #endregion
            driver.Url = url;
            NavBar.Login(path1,username, password,path2);
        }

        [TestMethod, TestCategory("positive")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "LoginClose", DataAccessMethod.Sequential)]

        public void loginClose()
        {
            //testing close button fuctionality in Login form
            string url = TestContext.DataRow["url"].ToString();
            string path = TestContext.DataRow["locator"].ToString();
            driver.Url = url;
            NavBar.loginC(path);
        }

        [TestMethod, TestCategory("negative")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "LoginNeg", DataAccessMethod.Sequential)]
        public void Loginneg()
        {
            #region
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string path = TestContext.DataRow["locator"].ToString();
            string url = TestContext.DataRow["url"].ToString();
            string checkMsg = TestContext.DataRow["msg"].ToString();
            #endregion
            driver.Url = url;
            NavBar.Loginneg(username, password, path);
            String msg = driver.SwitchTo().Alert().Text;
            Assert.AreEqual(checkMsg, msg);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
        }

        [TestMethod, TestCategory("positive/Negative")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SignupUser", DataAccessMethod.Sequential)]

        public void signupUser()
        {
            #region
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string path = TestContext.DataRow["locator"].ToString();
            string url = TestContext.DataRow["url"].ToString();
            string AlertMsg = TestContext.DataRow["msg"].ToString();
            #endregion
            driver.Url = url;
            NavBar.signupUser(username, password, path);
            String msg = driver.SwitchTo().Alert().Text;
            Assert.AreEqual(AlertMsg, msg);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
        }

        [TestMethod, TestCategory("positive")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SignupClose", DataAccessMethod.Sequential)]
        public void signupClose()
        {
            #region   
            string path = TestContext.DataRow["locator"].ToString();
            string url = TestContext.DataRow["url"].ToString();
            #endregion
            driver.Url = url;
            NavBar.signupClose(path);
        }

        [TestMethod, TestCategory("positive")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "contactForm", DataAccessMethod.Sequential)]
        public void contactForm()
        {
            #region
            string locator = TestContext.DataRow["locator"].ToString();
            string email = TestContext.DataRow["email"].ToString();
            string name = TestContext.DataRow["name"].ToString();
            string enterText = TestContext.DataRow["enterText"].ToString();
            string buttonLocator = TestContext.DataRow["buttonLocator"].ToString();
            string url = TestContext.DataRow["url"].ToString();
            #endregion
            driver.Url = url;
            NavBar.contactForm(locator,email,name,email,buttonLocator);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
        }

        [TestMethod, TestCategory("positive")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "contactFormClose", DataAccessMethod.Sequential)]
        public void contactFormClose()
        {
            #region 
            string path = TestContext.DataRow["locator"].ToString();
            string url = TestContext.DataRow["url"].ToString();
            #endregion
            driver.Url = url;
            NavBar.contactFormClose(path);
        }

        [TestMethod, TestCategory("positive")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "aboutus", DataAccessMethod.Sequential)]
        public void aboutUs()
        {
            #region
            string path1 = TestContext.DataRow["locator1"].ToString(); //locator for aboutus button 
            string path2 = TestContext.DataRow["locator2"].ToString(); //locator for video button in about us
            string url = TestContext.DataRow["url"].ToString();
            #endregion
            driver.Url = url;
            NavBar.aboutUs(path1, path2);
        }

        [TestMethod, TestCategory("positive")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "aboutusClose", DataAccessMethod.Sequential)]
        public void aboutUsClose()
        {
            #region
            string path1 = TestContext.DataRow["locator1"].ToString(); //locator for aboutus button 
            string path2 = TestContext.DataRow["locator2"].ToString(); //locator for close button in aboutus

            string url = TestContext.DataRow["url"].ToString();
            #endregion
            driver.Url = url;
            NavBar.aboutUsClose(path1, path2);
        }

        [TestMethod, TestCategory("positive")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "homeReturn", DataAccessMethod.Sequential)]
        public void home_Return()
        {
            #region
            string path = TestContext.DataRow["locator"].ToString(); //locate to cart button 

            string url = TestContext.DataRow["url"].ToString();
            #endregion
            driver.Url = url;
            NavBar.home_Return(path);
            string currentUrl = driver.Url;
            Assert.AreEqual(currentUrl, "https://www.demoblaze.com/index.html%22");
        }
        [TestMethod, TestCategory("positive")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "sliderPrevButton", DataAccessMethod.Sequential)]
        public void Picslider_Prev_Button()
        {
            string path = TestContext.DataRow["locator"].ToString();
            string url = TestContext.DataRow["url"].ToString();
            driver.Url = url;
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName(path)).Click(); //SLider Button locator
            Thread.Sleep(2000);
        }

        [TestMethod, TestCategory("positive")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "sliderForButton", DataAccessMethod.Sequential)]
        public void Picslider_Forw_Button()
        {
            string path = TestContext.DataRow["locator"].ToString();

            string url = TestContext.DataRow["url"].ToString();

            driver.Url = url;

            Thread.Sleep(2000);
            driver.FindElement(By.ClassName(path)).Click();
            Thread.Sleep(2000);

        }


        [TestMethod, TestCategory("negative")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "SignUpEmpty", DataAccessMethod.Sequential)]
        public void signupFieldEmpty()
        {

            #region
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            string path = TestContext.DataRow["locator"].ToString();
            string Alertmsg = TestContext.DataRow["msg"].ToString();

            string url = TestContext.DataRow["url"].ToString();
            #endregion
            driver.Url = url;
            NavBar.signupFieldEmpty(username,password,path);
            String msg = driver.SwitchTo().Alert().Text;
            Assert.AreEqual(Alertmsg, msg);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
        }

       
        [TestMethod, TestCategory("Positive")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "addToCartAllProducts", DataAccessMethod.Sequential)]
        public void AddtoCart_1()
        {
            #region
            //adding products in cart one by one 
            string cat = TestContext.DataRow["cat"].ToString(); //locator for aboutus button 
            string path1 = TestContext.DataRow["locator1"].ToString(); //locator for video button in about us
            string path2 = TestContext.DataRow["locator2"].ToString(); //locator for video button in about us
            string alertMsg = TestContext.DataRow["msg"].ToString();


            string url = TestContext.DataRow["url"].ToString();
            #endregion
            driver.Url = url;
            driver.FindElement(By.Id(cat)).Click(); //catogory locator
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(path1)).Click();  //Press to samsung
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(path2)).Click();  //Press to samsung
            Thread.Sleep(2000);
            String msg = driver.SwitchTo().Alert().Text;
            Thread.Sleep(2000);
            Assert.AreEqual(alertMsg, msg);
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
        }

        [TestMethod, TestCategory("Dependent on AddToCart()/Postive")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "addToCartAllProducts", DataAccessMethod.Sequential)]
        public void PlaceOrder()
        {
            AddtoCart_1();
            driver.FindElement(By.Id("cartur")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("#page-wrapper > div > div.col-lg-1 > button")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("name")).SendKeys("moiz");
            driver.FindElement(By.Id("card")).SendKeys("4515-415-415-4");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#orderModal > div > div > div.modal-footer > button.btn.btn-primary")).Click();
            Thread.Sleep(2000);
        }

        [TestMethod, TestCategory("Dependent on AddToCart()/Negative")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "addToCartAllProducts", DataAccessMethod.Sequential)]
        public void PlaceOrderNeg()
        {
            AddtoCart_1();
            driver.FindElement(By.Id("cartur")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("#page-wrapper > div > div.col-lg-1 > button")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("name")).SendKeys("moiz");
            driver.FindElement(By.Id("card")).SendKeys("");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#orderModal > div > div > div.modal-footer > button.btn.btn-primary")).Click(); //placeOrder button
            Thread.Sleep(2000);
            String msg = driver.SwitchTo().Alert().Text;
            Thread.Sleep(2000);
            Assert.AreEqual("Please fill out Name and Creditcard.", msg);
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
        }


        [TestMethod, TestCategory("Dependent on AddToCart()/Postive")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "addToCartAllProducts", DataAccessMethod.Sequential)]
       
        public void delete()
        { 
            AddtoCart_1();      //Calling Add to Cart function 
            driver.FindElement(By.Id("cartur")).Click();    //coming to cart
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#tbodyid > tr > td:nth-child(4) > a")).Click(); //press delete
            Thread.Sleep(4000);
        }


        [TestMethod, TestCategory("Positive")]
        public void next_Prev_Button()
        {
            driver.Url = "https://www.demoblaze.com/index.html";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("next2")).Click();    //coming to cart
            Thread.Sleep(2000);
            driver.FindElement(By.Id("prev2")).Click();
            Thread.Sleep(2000);
            driver.Close();
        }

       
    }





}
