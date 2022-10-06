using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Quiz
{
    [TestClass]

    
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        string browser_name = "chrome";
        string url = "https://automationexercise.com/";

        // GeneralMethod gm = new GeneralMethod();
        [TestMethod]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\ahmadnia\\source\\repos\\Quiz\\Quiz\\Class1.xml", "login", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {

            string name = TestContext.DataRow[0].ToString();
            string lastname = TestContext.DataRow[1].ToString();
            string email = TestContext.DataRow[2].ToString();
            string password = TestContext.DataRow[3].ToString();
            string companyname = TestContext.DataRow[5].ToString();
            string address = TestContext.DataRow[6].ToString();
            string state = TestContext.DataRow[7].ToString();
            string city = TestContext.DataRow[8].ToString();
            string zipcode = TestContext.DataRow[9].ToString();
            string mobile = TestContext.DataRow[10].ToString();




            SignUp sp = new SignUp();
            sp.BrowserMethod(browser_name);
            sp.BrowserUrl(url);
            sp.linkSign();
            sp.Name(name);
            sp.Email(email);
            sp.Button();
            sp.Tittle();
            sp.Password(password);
            sp.Date();
            sp.Month();
            sp.Year();
            sp.Newsletter();
            sp.Options();
            sp.Fristname(name);
            sp.Lastname(lastname);
            sp.CompanyName(companyname);
            sp.Address1(address);
            sp.Address2(address);
            sp.Country();
            sp.State(state);
            sp.City(city);
            sp.Zipcode(zipcode);
            sp.Mobile(mobile);
            sp.Creatbutton();




        }

        [TestMethod]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\ahmadnia\\source\\repos\\Quiz\\Quiz\\Class1.xml", "login", DataAccessMethod.Sequential)]
        public void testmethod2()
        {
            string emails = TestContext.DataRow[2].ToString();
            string passwords = TestContext.DataRow[3].ToString();

            login lg = new login();
            lg.BrowserMethod(browser_name);
            lg.BrowserUrl(url);
            lg.linkSign();
            lg.Emails(emails);
            lg.Passwords(passwords);
            lg.Button();


        }

        [TestMethod]

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "C:\\Users\\ahmadnia\\source\\repos\\Quiz\\Quiz\\Class1.xml", "login", DataAccessMethod.Sequential)]
        public void testmethod3()
        {
            string emails = TestContext.DataRow[2].ToString();
            string passwords = TestContext.DataRow[3].ToString();
            string serachbar = TestContext.DataRow[11].ToString();

            SearchProduct sptoduct = new SearchProduct();
            sptoduct.BrowserMethod(browser_name);
            sptoduct.BrowserUrl(url);
            sptoduct.linkSign();
            sptoduct.Emails(emails);
            sptoduct.Passwords(passwords);
            sptoduct.Button();
            sptoduct.Product();
            sptoduct.Serachbar(serachbar);
            sptoduct.Submit();


        }



    }
}