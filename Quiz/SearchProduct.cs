using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class SearchProduct : GeneralMethod
    {
        By LinkSignUp = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[4]/a");
        By emails = By.XPath("//input[@data-qa='login-email']");
        By passwords = By.XPath("//input[@data-qa='login-password']");
        By loginbutton = By.XPath("//button[@data-qa='login-button']");
        By product = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[2]/a");
        By serachproduct = By.Id("search_product");
        By submit = By.Id("submit_search");


        public void linkSign()
        {
            clickItems(LinkSignUp);

        }
        public void Emails(string ems)
        {
            clickItems(emails);
            Sendkeys(emails, ems);
        }

        public void Passwords(string pss)
        {
            clickItems(passwords);
            Sendkeys(passwords, pss);
        }

        public void Button()
        {
            clickItems(loginbutton);
        }

        public void Product()
        {
            clickItems(product);
        }

        public void Serachbar(string sb)
        {
            clickItems(serachproduct);
            Sendkeys(serachproduct, sb);
        }

        public void Submit()
        {
            clickItems(submit);
        }
    }
}
