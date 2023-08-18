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
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCode.Click();

            // Enter Code Value
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("Task7");

            //Enter Description 
            IWebElement description = driver.FindElement(By.Id("Description"));
            description.SendKeys("Task7 Description");

            //Enter Price Unit
            IWebElement price = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            price.SendKeys("20");

            //Click Save Button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 5);

            //Go to the last page
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();

            //select the las row of the records
            IWebElement actualData = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            //Validation the Actual records with Expected Record
            Assert.That(actualData.Text == "Task7", "New Record is not matching and Unsuccessful");
         
        }

        public void EditRecord(IWebDriver driver)
        {
            //click the last page arrow button
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span",5);

            IWebElement editLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            editLastPage.Click();


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
            IWebElement editCode = driver.FindElement(By.Id("Code"));
            editCode.Clear();
            editCode.SendKeys("task8");

            //Enter Description
            IWebElement editDescription = driver.FindElement(By.Id("Description"));
            editDescription.Clear();
            editDescription.SendKeys("Editing the Description");

            //Enter Price
            IWebElement editPriceOverlappingTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement editPrice = driver.FindElement(By.Id("Price"));
            editPriceOverlappingTag.Click();
            editPrice.Clear();
            editPriceOverlappingTag.Click();
            editPrice.SendKeys("500");

            //Click Save button
            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();
            
            Wait.WaitToBeVisible(driver, "XPath","//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 7);
     
            //go to last page and check the edited details
            IWebElement editLastPage1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            editLastPage1.Click();

            try
            {
                Wait.WaitToBeVisible(driver,"XPath","//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]", 5);

                IWebElement editedActualData = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
                Console.WriteLine(editedActualData);


                //validation Editingdata with Assertion
                Assert.That(editedActualData.Text == "task8","Edited records are not matching and unsuccessful");

            }catch( Exception ex)
            {
                Assert.Fail("why edit records are not matching", ex.Message);
            }

        }

        public void DeleteRecord( IWebDriver driver) 
        {
            //Locate the Delete button and Click
            try
            {
                Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]", 7);

                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();

                //Pop up msg --switching to Alert
                IAlert alert = driver.SwitchTo().Alert();
                string alertMsg = driver.SwitchTo().Alert().Text;
                Console.WriteLine(alertMsg);

                //click Ok
                alert.Accept();

            } catch ( Exception ex)

            { Assert.Fail("Cant find the element location",ex.Message); 
            }

        }

    }
}
