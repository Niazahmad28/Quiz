using OpenQA.Selenium;
using Quiz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz

{
    public class SignUp : GeneralMethod
    {
        By LinkSignUp = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[4]/a");
        By name = By.XPath("//input[@data-qa='signup-name']");
        By email = By.XPath("//input[@data-qa='signup-email']");
        By button = By.XPath("//button[@data-qa='signup-button']");
        By tittle = By.Id("id_gender1");
        By password = By.Id("password");
        By date = By.Id("days");
        By months = By.Id("months");
        By year = By.Id("years");
        By newsletter = By.Id("newsletter");
        By option = By.Id("optin");
        By fristname = By.Id("first_name");
        By lastname = By.Id("last_name");
        By companyname = By.Id("company");
        By address1 = By.Id("address1");
        By address2 = By.Id("address2");
        By country = By.Id("country");
        By state = By.Id("state");
        By city = By.Id("city");
        By zipcode = By.Id("zipcode");
        By mobile = By.Id("mobile_number");
        By createbutton = By.XPath("//button[@data-qa='create-account']"); 




        public void linkSign()
        {
            clickItems(LinkSignUp);

        }
        public void Name( string nm )
        {
            clickItems(name);
            Sendkeys(name, nm);
        }


        public void Email(string em)
        {
            clickItems(email);
            Sendkeys(email, em);
        }

        public void Button()
        {
            clickItems(button);
        }

        public void Tittle ()
        {
            clickItems(tittle);
        }

        public void Password (string ps)
        {
            clickItems(password);
            Sendkeys (password, ps);
        }

        public void Date ()
        {
            clickItems(date);
            selectFormDropDown(date,"28");
        }

        public void Month()
        {
            clickItems(months);
            selectFormDropDown(months, "11");
        }

        public void Year()
        {
            clickItems(year);
            selectFormDropDown(year, "1995");
        }

        public void Newsletter()
        {
            clickItems (newsletter);    
        }

        public void Options()
        {
            clickItems(option);
        }

        public void Fristname(string mn)
        {
            clickItems(fristname);
            Sendkeys(fristname, mn);
        }

        public void Lastname( string ln)
        {
            clickItems(lastname);
            Sendkeys(lastname,ln);
        }

        public void CompanyName ( string cn)
        {
            clickItems(companyname);
            Sendkeys(companyname, cn);
        }

        public void Address1 (string ad1 )
        {
            clickItems(address1);
            Sendkeys(address1, ad1);
        }

        public void Address2(string ad2)
        {
            clickItems(address2);
            Sendkeys(address2, ad2);
        }

        public void Country ()
        {
            clickItems(country);
            selectFormDropDown(country, "Australia");
        }

        public void State(string st)
        {
            clickItems(state);
            Sendkeys(state,st);
        }

        public void City (string ct)
        {
            clickItems(city);
            Sendkeys(city,ct);
        }

        public void Zipcode(string zp)
        {
            clickItems(zipcode);
            Sendkeys(zipcode, zp);
        }

        public void Mobile (string mb)
        {
            clickItems(mobile);
            Sendkeys(mobile,mb);
        }

        public void Creatbutton ()
        {
            clickItems(createbutton);
        }
    }













}