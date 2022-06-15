


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

//Create new Chrome Browser Instance
var driver = new ChromeDriver();

//Navigate to Wikipedia
driver.Navigate().GoToUrl("Http://wikipedia.org");

Console.WriteLine("CURRENT TITLE: " + driver.Title);

//Locate Search Feeld by ID
var searchField = driver.FindElement(By.Id("searchInput")); 

//Click on Element
searchField.Click();

//Fill with QA
searchField.SendKeys("QA" + Keys.Enter);

Console.WriteLine("TITLE AFTER SEARCH: " + driver.Title);

// Close the Browser
driver.Quit();