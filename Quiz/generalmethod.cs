using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Internal;

namespace Quiz
{
    public class GeneralMethod
    {
        public static IWebDriver driver;

        public GeneralMethod()
        {
            driver = null;
        }
        public void BrowserMethod(string browserName)
        {
            if (browserName.Equals("chrome", StringComparison.CurrentCultureIgnoreCase))
            {
                driver = new ChromeDriver();
            }
            else if (browserName.Equals("firefox", StringComparison.CurrentCultureIgnoreCase))
            {
                driver = new FirefoxDriver();
            }
        }
        public void BrowserUrl(string u)
        {
            driver.Url = u;
            driver.Manage().Window.Maximize();

        }
        public IWebElement FindLocator(By path)
        {
            return driver.FindElement(path);
        }
        public void clickItems(By path)
        {
            IWebElement clickItem = FindLocator(path);
            clickItem.Click();


            //IWebElement element = driver.FindElement(clickableitem);
            //Actions act = new Actions(driver);
            //act.Click(element).Build().Perform();


        }

        public void Sendkeys(By path , string str )
        {
            driver.FindElement(path).SendKeys(str);
        }

        public void selectFormDropDown (By path , string obj)
        {
            IWebElement element = FindLocator (path);
            SelectElement dropDownItem = new SelectElement(element);
            dropDownItem.SelectByValue(obj);
        }
    }
}