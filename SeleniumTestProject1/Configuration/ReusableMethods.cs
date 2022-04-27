using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestProject1.Configuration
{
    public class ReusableMethods
    {

        ChromeDriver Driver = new ChromeDriver();


        


        public void RedditLoginClick() {
            Driver.FindElement(By.XPath("//div//a[contains(text(),'Log In')]")).Click();
        }


        public void helloWorld() {
            Console.WriteLine("hello world");
        }

        public void GoToURL(string URL) {

            ChromeDriver Driver;
            ChromeOptions Options = new ChromeOptions();
            Options.AddArguments("--disable-notifications");
            Driver = new ChromeDriver(Options);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(URL);
        }
        
    }
    
}
