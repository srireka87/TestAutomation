using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
            employeeNameTextBox.SendKeys("Joe");

            //Enter Username
            IWebElement employeeUserNameTextBox = driver.FindElement(By.Id("Username"));
            employeeUserNameTextBox.SendKeys("Joe");

           //select Edit Contact button
            IWebElement employeeEditContactButton = driver.FindElement(By.Id("EditContactButton"));
            employeeEditContactButton.Click();

            //In create Employee --->EditContact fields-->Switching to new frame to enter Edit Contact Details

            //Switching to EditContact Page 
            driver.SwitchTo().Frame(0);

            Wait.WaitToBeVisible(driver, "Id", "FirstName", 3);
            //Enter First Name in Edit Contact Employees Page
            IWebElement firstNameEditContactTextBox = driver.FindElement(By.Id("FirstName"));
            firstNameEditContactTextBox.SendKeys("Joe");

            //Enter Last Name
            IWebElement lastNameEditContactTextBox = driver.FindElement(By.Id("LastName"));
            lastNameEditContactTextBox.SendKeys("Zoe");

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

            //Select  Groups dropdown list
           //
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='k-multiselect-wrap k-floatwrap']", 3);
            IWebElement groupLists = driver.FindElement(By.XPath("//div[@class='k-multiselect-wrap k-floatwrap']"));
            groupLists.Click();
          
          //Select the Group from the list
            Wait.WaitToBeVisible(driver, "XPath", "//div[@id='groupList-list']/ul/li[3]",5);
            IWebElement listoption1 = driver.FindElement(By.XPath("//div[@id='groupList-list']/ul/li[3]"));
            listoption1.Click();
            Thread.Sleep(4000);




            //Click Save Contact Button
            IWebElement employeeSaveButton = driver.FindElement(By.Id("SaveButton"));
            employeeSaveButton.Click();
            Wait.WaitToBeClickable(driver, "Id", "SaveButton", 3);

            IWebElement backToListLink = driver.FindElement(By.LinkText("Back to List"));
            backToListLink.Click();

            Wait.WaitToBeVisible(driver,"XPath","//*[@id=\"usersGrid\"]/div[4]/a[4]/span",3);

            //GoToLastPage arrowbutton click
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();

            //Validation with actual Employee data with Expected data ,in this case"Emma"
            Wait.WaitToBeVisible(driver,"XPath", "//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]",3);

            //Finding the ActualData after Creating a new Employee
            IWebElement actualCreateEmployeeData = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Console.WriteLine(actualCreateEmployeeData.Text);


            Assert.That(actualCreateEmployeeData.Text == "Joe","New Employee record was Unsuccessful");
        }

        public void EditEmployees(IWebDriver driver)
        {
            //GotoLastPage
            IWebElement goToLastPageArrowButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            goToLastPageArrowButton.Click();

            //Click the Edit Button
            IWebElement editEmployeesButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            editEmployeesButton.Click();

            //Enter EditEmployees Name
            IWebElement employeeNameTextBox = driver.FindElement(By.Id("Name"));
             employeeNameTextBox.Clear();
            employeeNameTextBox.SendKeys("Mercy");

            //Enter EditUsername
            IWebElement employeeUserNameTextBox = driver.FindElement(By.Id("Username"));
            employeeUserNameTextBox.Clear();
            employeeUserNameTextBox.SendKeys("Mercy");

            //select Edit Contact button
            IWebElement employeeEditContactButton = driver.FindElement(By.Id("EditContactButton"));
            employeeEditContactButton.Click();

            // Switching to EditContact Page
            driver.SwitchTo().Frame(0);

            Wait.WaitToBeVisible(driver, "Id", "FirstName", 3);
            //Enter First Name in Edit Contact Employees Page
            IWebElement firstNameEditContactTextBox = driver.FindElement(By.Id("FirstName"));
            firstNameEditContactTextBox.Clear();
            firstNameEditContactTextBox.SendKeys("Mercy");

            //Enter Last Name
            IWebElement lastNameEditContactTextBox = driver.FindElement(By.Id("LastName"));
            lastNameEditContactTextBox.Clear();
            lastNameEditContactTextBox.SendKeys("Sweety");

            //Enter Prefered Name
            IWebElement preferdNameEditContactTeXtBox = driver.FindElement(By.Id("PreferedName"));
            preferdNameEditContactTeXtBox.Clear();
            preferdNameEditContactTeXtBox.SendKeys("beautifulful");

            //Enter Phone number
            IWebElement phoneEditContactTeXtBox = driver.FindElement(By.Id("Phone"));
            phoneEditContactTeXtBox.Clear();
            phoneEditContactTeXtBox.SendKeys("5555555");

            //Enter Mobile number
            IWebElement mobileEditContactTeXtBox = driver.FindElement(By.Id("Mobile"));
            mobileEditContactTeXtBox.Clear();
            mobileEditContactTeXtBox.SendKeys("3333333");

            //Enter Email number
            IWebElement emailEditContactTeXtBox = driver.FindElement(By.Id("email"));
            emailEditContactTeXtBox.Clear();
            emailEditContactTeXtBox.SendKeys("beauty@gmail.com");

            //Enter Fax number
            IWebElement faxEditContactTeXtBox = driver.FindElement(By.Id("Fax"));
            faxEditContactTeXtBox.Clear();
            faxEditContactTeXtBox.SendKeys("3223532");

            //Enter Address
            IWebElement addressEditContactTeXtBox = driver.FindElement(By.Id("autocomplete"));
            //addressEditContactTeXtBox.SendKeys("34,sea street");

            //Enter Street
            IWebElement streetEditContactTeXtBox = driver.FindElement(By.Id("Street"));
            streetEditContactTeXtBox.Clear();
            streetEditContactTeXtBox.SendKeys(" 44,seaview street");

            //Enter City
            IWebElement cityEditContactTeXtBox = driver.FindElement(By.Id("City"));
            cityEditContactTeXtBox.Clear();
            cityEditContactTeXtBox.SendKeys("Florida");

            //Enter PostCode
            IWebElement postEditContactTeXtBox = driver.FindElement(By.Id("Postcode"));
            postEditContactTeXtBox.Clear();
            postEditContactTeXtBox.SendKeys("4545");

            //EnterCountry
            IWebElement countryEditContactTeXtBox = driver.FindElement(By.Id("Country"));
            countryEditContactTeXtBox.Clear();
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
            employeePasswordTextBox.Clear();
            employeePasswordTextBox.SendKeys("Steady@go1");

            //Enter Retype Password
            IWebElement employeeReTypePasswordTextBox = driver.FindElement(By.Id("RetypePassword"));
            employeeReTypePasswordTextBox.Clear();
            employeeReTypePasswordTextBox.SendKeys("Steady@go1");

            //Check IsAdmin Check box
            IWebElement employeeIsAdminCheckBox = driver.FindElement(By.Id("IsAdmin"));
            employeeIsAdminCheckBox.Click();

            //Enter Vehicle
            IWebElement employeeVehicleTextBox = driver.FindElement(By.Name("VehicleId_input"));
            employeeVehicleTextBox.Clear();
            employeeVehicleTextBox.SendKeys("BMW");

            //Group


            //Click Save Contact Button
            IWebElement employeeSaveButton = driver.FindElement(By.Id("SaveButton"));
            employeeSaveButton.Click();
            Wait.WaitToBeClickable(driver, "Id", "SaveButton", 3);

            IWebElement backToListLink = driver.FindElement(By.LinkText("Back to List"));
            backToListLink.Click();

            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"usersGrid\"]/div[4]/a[4]/span", 5);

            //go to last page and check the edited details
            IWebElement editGoToLastPage1 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            editGoToLastPage1.Click();

            IWebElement afterEditingActualData = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(afterEditingActualData.Text == "Mercy", "Actual Data and Expected Data are not matching");
        }
        public void DeleteEmployees(IWebDriver driver)

        {
            //Go to last page 
            IWebElement editGoToLastPage1 = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            editGoToLastPage1.Click();


            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]",5);

            //Locating Delete Button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            deleteButton.Click();

            Thread.Sleep(3000);

            IAlert alert = driver.SwitchTo().Alert();

            string alertText = driver.SwitchTo().Alert().Text;
            Console.WriteLine(alertText);

            alert.Accept();
            
           // Validation
            IWebElement deleteActualData =driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(deleteActualData.Text !="Mercy","Expected Employee Records undeleted");
        } 
    }
}
