using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalAutomation.Utilities;

namespace TurnUpPortalAutomation.Pages
{
    public class EmployeesPage:Wait
    {

        public void CreateEmployees(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            //Click Create  Button for New Employees details

            IWebElement createEmployeesButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createEmployeesButton.Click();

            //Enter Employees Name
            IWebElement employeeNameTextBox = driver.FindElement(By.Id("Name"));
            employeeNameTextBox.SendKeys("Emma");

            //Enter Username
            IWebElement employeeUserNameTextBox = driver.FindElement(By.Id("Username"));
            employeeUserNameTextBox.SendKeys("Emma Lord");

           //select Edit Contact button
            IWebElement employeeEditContactButton = driver.FindElement(By.Id("EditContactButton"));
            employeeEditContactButton.Click();

            //In create Employee --->EditContact fields-->Switching to new frame to enter Edit Contact Details

            //Switching to EditContact Page when I click EditContact Button
            driver.SwitchTo().Frame(0);

            Wait.WaitToBeVisible(driver, "Id", "FirstName", 3);
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
            IWebElement emailEditContactTeXtBox = driver.FindElement(By.Id("email"));
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


            /*Calling Edit Contact Employees Details into this class 
            EmployeesPageEditContact editcontactobj = new EmployeesPageEditContact();
            editcontactobj.EmployeesPageEditContactDetails( driver);*/

            //switching to origin window
            driver.SwitchTo().DefaultContent();

            Wait.WaitToBeVisible(driver, "Id", "Password", 3);

            //Enter Password
            IWebElement employeePasswordTextBox = driver.FindElement(By.Id("Password"));
            employeePasswordTextBox.SendKeys("Ready@go1");

            //Enter Retype Password
            IWebElement employeeReTypePasswordTextBox = driver.FindElement(By.Id("RetypePassword"));
            employeeReTypePasswordTextBox.SendKeys("Ready@go1");

            //Check IsAdmin Check box
            IWebElement employeeIsAdminCheckBox = driver.FindElement(By.Id("IsAdmin"));
            employeeIsAdminCheckBox.Click();

            //Enter Vehicle
            IWebElement employeeVehicleTextBox = driver.FindElement(By.Name("VehicleId_input"));
            employeeVehicleTextBox.SendKeys("swift");

            /*Enter Groups
            IWebElement employeeGroupTextBox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            employeeGroupTextBox.SendKeys("group2");*/

            //Click Save Contact Button
            IWebElement employeeSaveContactButton = driver.FindElement(By.Id("SaveButton"));
            employeeSaveContactButton.Click();

            IWebElement backToListLink = driver.FindElement(By.LinkText("Back to List"));
            backToListLink.Click();

            Wait.WaitToBeVisible(driver,"XPath","//*[@id=\"usersGrid\"]/div[4]/a[4]/span",3);

            //GoToLastPage arrowbutton click
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();

            //Validation with actual Employee data with Expected data ,in this case"Emma"

            //Finding the ActualData after Creating a new Employee
            IWebElement actualCreateEmployeeData = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(actualCreateEmployeeData.Text == "Emma", "New Employee record was Unsuccessful");
        }

        public void EditEmployees(IWebDriver driver)
        { }
        public void DeleteEmployees(IWebDriver driver)
        { } 
    }
}
