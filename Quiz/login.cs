using OpenQA.Selenium;
using Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class login : GeneralMethod
    {
        By LinkSignUp = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[4]/a");
        By emails = By.XPath("//input[@data-qa='login-email']");
        By passwords = By.XPath("//input[@data-qa='login-password']");
        By loginbutton = By.XPath("//button[@data-qa='login-button']");


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
    }
}
