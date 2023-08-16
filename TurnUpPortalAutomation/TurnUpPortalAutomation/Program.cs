

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUpPortalAutomation.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        
        LoginPage loginPageObj  =new LoginPage();
        loginPageObj.LoginFunction(driver);

        HomePage homePageObj = new HomePage();
        homePageObj.GoToTimeMaterialPage(driver);

        TimeMaterialPage timeMaterialPageObj =new TimeMaterialPage();
        timeMaterialPageObj.CreateTimeRecord(driver);

        timeMaterialPageObj.EditRecord(driver);
        timeMaterialPageObj.DeleteRecord(driver);




       


        
        
        
    }
}

