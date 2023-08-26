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
    [Parallelizable]

    [TestFixture]
    public class EmployeesTests:CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        EmployeesPage employeesPageObj = new EmployeesPage();


        [SetUp]
        public void EmployeesSetUp()
        {
            driver = new ChromeDriver();
            loginPageObj.LoginFunction(driver);
            homePageObj.GoToEmployeesPage(driver);
        }

        [Test, Order(1), Description("This test is used to create a New Employees Records")] 
        public void CreateEmployees_Test()
        { 
            
            employeesPageObj.CreateEmployees(driver);
  
        }

        [Test, Order(2), Description("This test is used to Edit the Employees Records")]
        public void EditEmployees_Test()
        {
            employeesPageObj.EditEmployees(driver);
        }

        [Test, Order(3), Description("This test is used to delete the Employees Records")]
        public void DeleteEmployees_Test()
        {
            employeesPageObj.DeleteEmployees(driver);

        }
       [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }

}
