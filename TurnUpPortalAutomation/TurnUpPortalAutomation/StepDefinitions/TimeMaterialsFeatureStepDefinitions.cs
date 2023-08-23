using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TurnUpPortalAutomation.Pages;
using TurnUpPortalAutomation.Utilities;

namespace TurnUpPortalAutomation.StepDefinitions
{
    [Binding]
    public class TimeMaterialsFeatureStepDefinitions:CommonDriver
    {
        [Given(@"I logged in to Turn Up Portal successfully")]
        public void GivenILoggedInToTurnUpPortalSuccessfully()
        {
            driver= new ChromeDriver();
            LoginPage loginPageObj=new LoginPage();
            loginPageObj.LoginFunction(driver);
        }

        [Given(@"I navigate to Time and Materials Page")]
        public void GivenINavigateToTimeAndMaterialsPage()
        {
            HomePage homePageObj=new HomePage();
            homePageObj.GoToTimeMaterialPage(driver);
        }

        [When(@"I create a new time records")]
        public void WhenICreateANewTimeRecords()
        {
            TimeMaterialPage timeMaterialPageObj=new TimeMaterialPage();
            timeMaterialPageObj.CreateTimeRecord(driver);
        }

        [Then(@"the new record should be created successfully")]
        public void ThenTheNewRecordShouldBeCreatedSuccessfully()
        {
            TimeMaterialPage timeMaterialPageObj = new TimeMaterialPage();
            string newActualData =timeMaterialPageObj.GetActualData(driver);
            Assert.That(newActualData == "Task7","New Record is not matching and Unsuccessful");
        }
    }
}
