using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTestProject1
{
    public class PWC_Tests {

        

        ChromeDriver Driver;

        [SetUp]
        public void Setup()
        {
            
            ChromeOptions Options = new ChromeOptions();
            Options.AddArguments("--disable-notifications");
            Driver = new ChromeDriver(Options);


            Driver.Manage().Window.Maximize();
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10)); wait object to be used
        }

        
        [Category("Sanity AM")]
        [Test]
        public void test1() {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.Navigate().GoToUrl("https://login.pwc.com");
            wait.Until(webDriver => webDriver.FindElement(By.Id("initEmail")).Displayed);
            Driver.FindElement(By.Id("initEmail")).SendKeys("qaprod45+11@gmail.com");
            Driver.FindElement(By.XPath("(//*[text()[contains(.,'Next')]])[1]")).SendKeys(Keys.Enter);
            wait.Until(webDriver => webDriver.FindElement(By.XPath("//input[@type='password']")).Displayed);
            Driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("welcome123!!!");
            Driver.FindElement(By.XPath("//*[contains(text(),'Submit')]")).SendKeys(Keys.Enter);

            if(wait.Until(webDriver => webDriver.FindElement(By.XPath("//*[contains(text(),' Welcome, you have successfully logged in.')]")).Displayed) == true)
            {
                Console.WriteLine("Success");
            }

            Driver.Close();

        }
        [Category("Sanity AM")]
        [Test]
        public void test2() {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.Navigate().GoToUrl("https://login.pwc.com");
            wait.Until(webDriver => webDriver.FindElement(By.Id("initEmail")).Displayed);
            Driver.FindElement(By.Id("initEmail")).SendKeys("qaprod45+11@gmail.com");
            Driver.FindElement(By.XPath("(//*[text()[contains(.,'Next')]])[1]")).SendKeys(Keys.Enter);
            wait.Until(webDriver => webDriver.FindElement(By.XPath("//input[@type='password']")).Displayed);
            Driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("welcome123!!!");
            Driver.FindElement(By.XPath("//*[contains(text(),'Submit')]")).SendKeys(Keys.Enter);

            if (wait.Until(webDriver => webDriver.FindElement(By.XPath("//*[contains(text(),' Welcome, you have successfully logged in.')]")).Displayed) == true)
            {
                Console.WriteLine("Success");
            }

            Driver.Close();

        }



        [TearDown]
        public void Teardown(){
            //Driver.Close();
        }





    }
  
   







}