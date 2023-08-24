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
    [TestFixture]
    public class TimeMaterialTest:CommonDriver
    {
        [SetUp]
        public void SetUpTM()
        {
            driver = new ChromeDriver();

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginFunction(driver);

            HomePage homePageObj = new HomePage();
            homePageObj.GoToTimeMaterialPage(driver);
        }

        [Test,Order(1),Description("This test is used to create a New Time&Materials Records")]
        public void CreateTM_Test()
        {
            TimeMaterialPage timeMaterialPageObj = new TimeMaterialPage();
            timeMaterialPageObj.CreateTimeRecord(driver);

        }
        [Test,Order(2),Description("This test is used to update the Time&Materials Records")]
        public void EditTM_Test()
        {
            TimeMaterialPage timeMaterialPageObj = new TimeMaterialPage();
            timeMaterialPageObj.EditRecord(driver,"PassingArguments");
        }
        [Test,Order(3),Description("This test is used to delete the Time&Materials Records")]
        public void DeleteTM_Test()
        {
            TimeMaterialPage timeMaterialPageObj = new TimeMaterialPage();
            timeMaterialPageObj.DeleteRecord(driver);
        }
        [TearDown] 
        public void CloseTestRun()
        {
           driver.Quit();

        }


    }
}
