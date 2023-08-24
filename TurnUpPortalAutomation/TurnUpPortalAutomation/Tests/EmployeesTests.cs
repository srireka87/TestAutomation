using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalAutomation.Pages;
using TurnUpPortalAutomation.Utilities;

namespace TurnUpPortalAutomation.Tests
{
    [TestFixture]
    public class EmployeesTests:CommonDriver
    {
        [SetUp]
        public void EmployeesSetUp()
        {
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginFunction(driver);

            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeesPage(driver);
        }

        [Test, Order(1), Description("This test is used to create a New Employees Records")] 
        public void CreateEmployees_Test()
        { 
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.CreateEmployees(driver);
  
        }

        [Test, Order(2), Description("This test is used to Edit the Employees Records")]
        public void EditEmployees_Test()
        {
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.EditEmployees(driver);
        }

        [Test, Order(3), Description("This test is used to delete the Employees Records")]
        public void DeleteEmployees_Test()
        {
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.DeleteEmployees(driver);

        }
      /* [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }*/
    }

}
