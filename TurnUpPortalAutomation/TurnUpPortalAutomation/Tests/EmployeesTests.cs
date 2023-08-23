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

        [Test] 
        public void CreateEmployees_Test()
        { 
            EmployeesPage employeesPageObj = new EmployeesPage();
            employeesPageObj.CreateEmployees(driver);
  
        }

        /*[Test]
        public void EditEmployees_Test()
        {

        }

        [Test]
        public void DeleteEmployees_Test()
        { 
        }
       [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }*/
    }

}
