using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TurnUpPortalAutomation.Pages
{
    public class EmployeesPageEditContact
    {
        public  void EmployeesPageEditContactDetails(IWebDriver driver)
        {
            //string handle = driver.getWindowHandle();

            //Enter First Name in Edit Contact Employees Page
            IWebElement firstNameEditContactTextBox = driver.FindElement(By.Id("FirstName"));
            firstNameEditContactTextBox.SendKeys("Carla");

            //Enter Last Name
            IWebElement lastNameEditContactTextBox = driver.FindElement(By.Id("LastName"));
            lastNameEditContactTextBox.SendKeys("Love");

            //Enter Prefered Name
            IWebElement preferdNameEditContactTeXtBox = driver.FindElement(By.Id("PreferedName"));
            preferdNameEditContactTeXtBox.SendKeys("bestie");

            //Enter Phone number
            IWebElement phoneEditContactTeXtBox = driver.FindElement(By.Id("Phone"));
            phoneEditContactTeXtBox.SendKeys("86756456");

            //Enter Mobile number
            IWebElement mobileEditContactTeXtBox = driver.FindElement(By.Id("Mobile"));
            mobileEditContactTeXtBox.SendKeys("67567576");

            //Enter Email number
            IWebElement emailEditContactTeXtBox = driver.FindElement(By.Id("c"));
            emailEditContactTeXtBox.SendKeys("best@gmail.com");

            //Enter Fax number
            IWebElement faxEditContactTeXtBox = driver.FindElement(By.Id("Fax"));
            faxEditContactTeXtBox.SendKeys("3223532");

            //Enter Address
            IWebElement addressEditContactTeXtBox = driver.FindElement(By.Id("autocomplete"));
            // addressEditContactTeXtBox.SendKeys("34,sea street");

            //Enter Street
            IWebElement streetEditContactTeXtBox = driver.FindElement(By.Id("Street"));
            streetEditContactTeXtBox.SendKeys(" 34,sea street");

            //Enter City
            IWebElement cityEditContactTeXtBox = driver.FindElement(By.Id("City"));
            cityEditContactTeXtBox.SendKeys("CA");

            //Enter PostCode
            IWebElement postEditContactTeXtBox = driver.FindElement(By.Id("Postcode"));
            postEditContactTeXtBox.SendKeys("3434");

            //EnterCountry
            IWebElement countryEditContactTeXtBox = driver.FindElement(By.Id("Country"));
            countryEditContactTeXtBox.SendKeys("USA");

            //Click Save Contact button
            IWebElement saveEditContactButton = driver.FindElement(By.Id("submitButton"));
            saveEditContactButton.Click();



        }
    }
}
