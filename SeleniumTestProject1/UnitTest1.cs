using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTestProject1
{
    public class Tests{
        String test_url = "https://www.reddit.com";

        IWebDriver Driver;
        
        [SetUp]
        public void Setup()
        {
            ChromeOptions Options = new ChromeOptions();
            Options.AddArguments("--disable-notifications");

            Driver = new ChromeDriver(Options);
            Driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test1(){
            
            Driver.Url = test_url;
            Driver.FindElement(By.XPath("//*[contains(text(),'Log In')]")).Click();
           
        }

        [Test]
        public void Test2() {
            Driver.Url = test_url;

           

        }

        [TearDown]
        public void Teardown() 
        {
            Driver.Close();
        }
    }
}