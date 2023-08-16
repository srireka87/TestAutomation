﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //Telling the Browser to wait until the page load
            Thread.Sleep(5000);


            //Go to the last page
            IWebElement goToLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPage.Click();

            //select the las row of the records
            IWebElement actualData = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            //Validation the Actual records with Expected Record
            if (actualData.Text == "Task7")
            {
                Console.WriteLine("New Record is matching and created successfully");

            }
            else
            {
                Console.WriteLine("New Record is not matching and Unsuccessful");
            }

            Thread.Sleep(2000);
        }
        public void EditRecord(IWebDriver driver)
        {
            //Edit /Delete Functionality
            //Go to the last page to click Edit button of the last row record
            Thread.Sleep(2000);

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


            Thread.Sleep(1000);

            //Click Save button
            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();

            Thread.Sleep(1000);
            //go to last page and check the edited details
            IWebElement editLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            editLastPage.Click();

            IWebElement editedActualData = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Console.WriteLine(editedActualData);

            //validation Editingdata
            if (editedActualData.Text == "task8")
            {
                Console.WriteLine("Edited Record details are matching and successfull");
            }
            else
            {
                Console.WriteLine("Edited records are not matching and unsuccessful");
            }

            Thread.Sleep(1000);

        }

        public void DeleteRecord( IWebDriver driver) 
        {
            //Delete the records
            //locate the Delete button and Click
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();

            //Pop up msg --switching to Alert
            IAlert alert = driver.SwitchTo().Alert();
            string alertMsg = driver.SwitchTo().Alert().Text;
            Console.WriteLine(alertMsg);

            Thread.Sleep(1000);
            //click Ok
            alert.Accept();
        }

    }
}
