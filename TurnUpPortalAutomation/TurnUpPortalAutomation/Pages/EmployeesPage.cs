using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortalAutomation.Pages
{
    public class EmployeesPage
    {

        public void CreateEmployees(IWebDriver driver)
        {
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


           // //switching  to Edit contact page window 
           //driver.getWindowHandle();
           // driver.SwitchTo().Window(String );

           // IWebElement employeeEditContactWindow = driver.FindElement(By.Id("contactDetailWindow_wnd_title"));
           // String EditContactNewPAgePopUp = employeeEditContactWindow.Text;

           // //Assert.Equals(EditContactNewPAgePopUp, employeeNameTextBox.Text);

            ////Calling Edit Contact Employees Details into this class 
            //EmployeesPageEditContact editcontactobj = new EmployeesPageEditContact();
            //editcontactobj.EmployeesPageEditContactDetails( driver);

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

            //Enter Groups
            IWebElement employeeGroupTextBox = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            employeeGroupTextBox.SendKeys("group2");

            //Click Save Contact Button
            IWebElement employeeSaveContactButton = driver.FindElement(By.Id("SaveButton"));
            employeeSaveContactButton.Click();
        }

        public void EditEmployees(IWebDriver driver)
        { }
        public void DeleteEmployees(IWebDriver driver)
        { } 
    }
}
