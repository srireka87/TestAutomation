﻿

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



