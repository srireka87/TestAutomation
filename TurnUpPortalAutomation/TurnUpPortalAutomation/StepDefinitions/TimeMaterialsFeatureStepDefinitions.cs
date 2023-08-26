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
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TimeMaterialPage timeMaterialPageObj = new TimeMaterialPage();

        [Given(@"I logged in to Turn Up Portal successfully")]
        public void GivenILoggedInToTurnUpPortalSuccessfully()
        {
            driver= new ChromeDriver();
            loginPageObj.LoginFunction(driver);
        }

        [Given(@"I navigate to Time and Materials Page")]
        public void GivenINavigateToTimeAndMaterialsPage()
        {
            homePageObj.GoToTimeMaterialPage(driver);
        }

        [When(@"I create a new time records")]
        public void WhenICreateANewTimeRecords()
        {
             timeMaterialPageObj.CreateTimeRecord(driver);
        }

        [Then(@"the new record should be created successfully")]
        public void ThenTheNewRecordShouldBeCreatedSuccessfully()
        {
            string newActualData =timeMaterialPageObj.GetActualData(driver);
            Assert.That(newActualData == "Task7","New Record is not matching and Unsuccessful");
            timeMaterialPageObj.CloseTheDriver(driver);

        }

        
        [When(@"I  update '([^']*)' '([^']*)'on existing Time Records")]
        public void WhenIUpdateOnExistingTimeRecords(string p0, string p1)
        {
            timeMaterialPageObj.EditRecord(driver,p0, p1);

        }

        [Then(@"the record should have updated '([^']*)' '([^']*)'")]
        public void ThenTheRecordShouldHaveUpdated(string p0, string p1)
        {
           string editActualcode =timeMaterialPageObj.GetEditedCode(driver);
           string editActualDescription =timeMaterialPageObj.GetEditedDescrption(driver);
           Assert.That(editActualcode==p0,"Actual code and Expected Code are not matching");

           Assert.That(editActualDescription==p1,"Actual Descriptions and Edited Descriptions are not matching");

           timeMaterialPageObj.CloseTheDriver(driver);


        }

        [When(@"I delete a New Time Material Record")]
        public void WhenIDeleteANewTimeMaterialRecord()
        {
            timeMaterialPageObj.DeleteRecord(driver);
        }

        [Then(@"the existing record should be deleted successfully")]
        public void ThenTheExistingRecordShouldBeDeletedSuccessfully()
        {
           
            string deletedActualData1=timeMaterialPageObj.GetDeleteTMRecord(driver);
            Assert.That(deletedActualData1 =="August01","Expected Time and Records undeleted");
            timeMaterialPageObj.CloseTheDriver(driver);


        }


    }
}
