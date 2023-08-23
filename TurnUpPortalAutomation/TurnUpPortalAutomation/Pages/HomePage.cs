using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalAutomation.Utilities;

namespace TurnUpPortalAutomation.Pages;

public class HomePage

{
    public void GoToTimeMaterialPage(IWebDriver driver)
    {

        //Go to Administration tab
        IWebElement adminTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        adminTab.Click();

        Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 7);

        //select the Time and Materials option from Administration Drop down menu
        IWebElement timeMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        timeMaterialOption.Click();
    }

    public void GoToEmployeesPage(IWebDriver driver)
    {
        //Go to Administration tab
        IWebElement adminTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
        adminTab.Click();

        //select the Employees Option from the drop down
        IWebElement employeesOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
        employeesOption.Click();
    }

}

    

