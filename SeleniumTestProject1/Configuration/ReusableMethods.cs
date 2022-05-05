using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestProject1.Configuration
{
    public class ReusableMethods : Constants
    {
     
        //public ReusableMethods() {}    




        public void OpenBrowser(string browserType) {

            if (TestContext.Parameters["Browser"] == "Chrome")
            {
                Driver = new ChromeDriver();
                Driver.Manage().Window.Maximize();

            }
            else if (TestContext.Parameters["Browser"] == "Firefox")
            {
                Driver = new FirefoxDriver();
                Driver.Manage().Window.Maximize();
            }


            //ChromeOptions Options = new ChromeOptions();
            //Options.AddArguments("--disable-notifications");
            //Driver = new ChromeDriver(Options);
            //Driver.Manage().Window.Maximize();
            //Driver.Navigate().GoToUrl(URL);
        }
       


    }
    
}
