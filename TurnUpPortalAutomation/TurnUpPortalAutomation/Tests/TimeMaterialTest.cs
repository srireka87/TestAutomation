using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalAutomation.Pages;
using TurnUpPortalAutomation.Utilities;

namespace TurnUpPortalAutomation.Tests
{
   // [Parallelizable]

    [TestFixture]
    public class TimeMaterialTest:CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TimeMaterialPage timeMaterialPageObj = new TimeMaterialPage();

        [SetUp]
        public void SetUpTM()
        {
            driver = new ChromeDriver();
           
            loginPageObj.LoginFunction(driver);
            homePageObj.GoToTimeMaterialPage(driver);
        }

        [Test,Order(1),Description("This test is used to create a New Time&Materials Records")]
        public void CreateTM_Test()
        {
            timeMaterialPageObj.CreateTimeRecord(driver);

        }
        [Test,Order(2),Description("This test is used to update the Time&Materials Records")]
        public void EditTM_Test()
        {
            timeMaterialPageObj.EditRecord(driver,"PassingArguments1","Passingarguments2");
        }

        [Test,Order(3),Description("This test is used to delete the Time&Materials Records")]
        public void DeleteTM_Test()
        {
            timeMaterialPageObj.DeleteRecord(driver);
        }
        [TearDown] 
        public void CloseTestRun()
        {
           driver.Quit();

        }
      

    }
}
