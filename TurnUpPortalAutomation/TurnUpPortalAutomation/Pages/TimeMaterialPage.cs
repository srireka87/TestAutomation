using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUpPortalAutomation.Utilities;

namespace TurnUpPortalAutomation.Pages
{
    public class TimeMaterialPage

    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            //Click Create New Button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            //Create New Page -Select the Typecode dropdown option (Time Material)
            IWebElement typeCodeDropDown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCodeDropDown.Click();

            // Enter Code Value
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("Task7");

            //Enter Description 
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("Task7 Description");

            //Enter Price Unit
            IWebElement priceTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextBox.SendKeys("20");

            //Click Save Button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 5);

            //Go to the last page
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();
         
        }

        public string GetActualData(IWebDriver driver)
        { //select the last row of the records
            IWebElement actualData = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return actualData.Text;
        }

        public void EditRecord(IWebDriver driver,string code1, string code2)
        {
            //click the last page arrow button
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span",5);

            IWebElement editGoToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            editGoToLastPage.Click();


            Wait.WaitToBeClickable(driver, "XPath", "//tbody/tr[last()]/td[5]/a[1]", 5);

            //Click Edit button
            IWebElement editButton = driver.FindElement(By.XPath("//tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            //Select Typo Code
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            IWebElement timeTypeCode = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeTypeCode.Click();

            //Enter Code
            IWebElement editCodeTextBox = driver.FindElement(By.Id("Code"));
            editCodeTextBox.Clear();
            editCodeTextBox.SendKeys(code1);

            //Enter Description
            IWebElement editDescriptionTextBox = driver.FindElement(By.Id("Description"));
            editDescriptionTextBox.Clear();
            editDescriptionTextBox.SendKeys(code2);

            //Enter Price
            IWebElement editPriceOverlappingTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement editPriceTextBox = driver.FindElement(By.Id("Price"));
            editPriceOverlappingTag.Click();
            editPriceTextBox.Clear();
            editPriceOverlappingTag.Click();
            editPriceTextBox.SendKeys("500");

            //Click Save button
            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();
            
            Wait.WaitToBeVisible(driver, "XPath","//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 7);
     
            //go to last page and check the edited details
            IWebElement editGoToLastPage1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            editGoToLastPage1.Click();    

        }
        //For the Code Validation ,Returning the Actual Code Data
        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement editedCodeActualData = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedCodeActualData.Text;
        }

        //For the Description Validation, returning the actual description data
        public string GetEditedDescrption(IWebDriver driver)
        {
            IWebElement editedDescrptionActualData = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            return editedDescrptionActualData.Text;
        }

        public void CloseTheDriver(IWebDriver driver)
        {
            driver.Quit();
        }

        public void DeleteRecord(IWebDriver driver)
        {
            //Locate the Delete button and Click
            {

                //Go to last page 
                IWebElement editGoToLastPage1 = driver.FindElement(By.XPath(" //*[@id=\"tmsGrid\"]/div[4]/a[4]/span "));
                editGoToLastPage1.Click();

                Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]",5);

                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();

                //Pop up msg --switching to Alert
                IAlert alert = driver.SwitchTo().Alert();
                string alertMsg = driver.SwitchTo().Alert().Text;

                //click Ok
                alert.Accept();
                
            }
        }
             public string GetDeleteTMRecord(IWebDriver driver)
              {
                  IWebElement deletedActualData = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
                  return deletedActualData.Text;
              }
            
    }
}

