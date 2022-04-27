using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestProject1.Configuration
{
    class TechListic : ReusableMethods
    {
        readonly ChromeDriver Driver;

        public void signup(string firstname, string lastname, string date) {


            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(webDriver => webDriver.FindElement(By.XPath("//div//input[@name='firstname']")).Displayed);
            Driver.FindElement(By.XPath("//div//input[@name='firstname']")).SendKeys(firstname);
            Driver.FindElement(By.XPath("//div//input[@name='lastname']")).SendKeys(lastname);
            Driver.FindElement(By.XPath("//div//input[@id='sex-0']")).Click();
            Driver.FindElement(By.XPath("//div//input[@id='datepicker']")).SendKeys(date);


        }

        
    }
}
