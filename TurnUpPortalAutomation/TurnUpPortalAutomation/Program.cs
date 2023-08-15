

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver(); 
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
driver.Manage().Window.Maximize();
 
IWebElement usernameTextbox= driver.FindElement(By.Id("UserName")); 
usernameTextbox.SendKeys("hari"); 

 IWebElement passwordTextbox = driver.FindElement(By.Id("Password")); 
passwordTextbox.SendKeys("123123"); 

 IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]")); 
loginButton.Click(); 

IWebElement hariHari =driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if (hariHari.Text=="Hello hari!")
{
    Console.WriteLine("User has logged in successfully");
}
else
{
    Console.WriteLine("Login Unsuccessful");
}



//week 3-Bruno's task -Time & Materials --Create New 

//invoke the browser and go to URl -Already done

//Go to Administration tab
IWebElement adminTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
adminTab.Click();

//select the Time and Materials option in Administration Drop down menu
IWebElement timeMaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeMaterialOption.Click();

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
if(actualData.Text == "Task7")
{
    Console.WriteLine("New Record is matching and created successfully");

}
else
{
    Console.WriteLine("New Record is not matching and Unsuccessful");
}





