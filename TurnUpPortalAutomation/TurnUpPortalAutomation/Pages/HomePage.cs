using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortalAutomation.Pages
{
    public class HomePage

    {
        public void GoToTimeMaterialPage(IWebDriver driver)
        {

            //Go to Administration tab
            IWebElement adminTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminTab.Click();

            //select the Time and Materials option in Administration Drop down menu
            IWebElement timeMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterialOption.Click();
        }
    }
}
