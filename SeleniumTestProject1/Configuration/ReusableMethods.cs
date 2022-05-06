using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestProject1.Configuration
{
    public class ReusableMethods : Constants
    {

        //public ReusableMethods() {}    

        internal static string Environment = "";
        internal static string DefaultExecutiontype = "";








        public void OpenBrowser(string browserType) {

            if (TestContext.Parameters["DefaultExecutiontype"] == "chrome")
            {
                Driver = new ChromeDriver();
                Driver.Manage().Window.Maximize();

            }
            else if (TestContext.Parameters["DefaultExecutiontype"] == "firefox")
            {
                Driver = new FirefoxDriver();
                Driver.Manage().Window.Maximize();
            }
            else if (TestContext.Parameters["DefaultExecutiontype"] == "edge")
            {
                Driver = new EdgeDriver();
                Driver.Manage().Window.Maximize();

            }
            
        }


        public void LaunchApp(string app)
        {
            Driver.Navigate().GoToUrl(app);

        }


    }
    
}
