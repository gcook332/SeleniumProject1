using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumTestProject1.Configuration;
using TestContext = NUnit.Framework.TestContext;

namespace SeleniumTestProject1.TestScripts
{
    
    [TestFixture]
    [Parallelizable(Constants.ParallelExecutionScope)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    class ParallelTests : ReusableMethods
    {
        


        [Test]
        [Category("parallelTests")]
        public void Login() {


            ChromeOptions Options = new ChromeOptions();
            Options.AddArguments("--disable-notifications");
            Driver = new ChromeDriver(Options);
            Driver.Manage().Window.Maximize();



            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.Navigate().GoToUrl("https://www.reddit.com");
            wait.Until(webDriver => webDriver.FindElement(By.XPath("//div//a[contains(text(),'Log In')]")).Displayed);
            Driver.FindElement(By.XPath("//div//a[contains(text(),'Log In')]")).Click();
            wait.Until(webDriver => webDriver.FindElement(By.XPath("//iframe[@class='_25r3t_lrPF3M6zD2YkWvZU']")).Displayed);
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@class='_25r3t_lrPF3M6zD2YkWvZU']")));
            wait.Until(webDriver => webDriver.FindElement(By.XPath("//input[@id='loginUsername']")).Displayed);
            Driver.FindElement(By.XPath("//input[@id='loginUsername']")).SendKeys("Hellraze1");
            Driver.FindElement(By.XPath("//input[@id='loginPassword']")).SendKeys("382982ff");
            Driver.FindElement(By.XPath("(//fieldset//button)[1]")).Click();

        }

        
        [Test]
        [Category("parallelTests")]
        public void Login2()
        {
            ReusableMethods RM = new ReusableMethods();
            Driver = new ChromeDriver();

            Driver.Navigate().GoToUrl("https://reddit.com");
            if (Driver.FindElement(By.XPath("(//div//span)[1][1]")).Displayed) {
                return;
            }
           
        }


        [Test]
        [Category("parallelTests")]
        public void Login3()
        {


            ChromeOptions Options = new ChromeOptions();
            Options.AddArguments("--disable-notifications");
            Driver = new ChromeDriver(Options);
            Driver.Manage().Window.Maximize();



            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.Navigate().GoToUrl("https://www.reddit.com");
            wait.Until(webDriver => webDriver.FindElement(By.XPath("//div//a[contains(text(),'Log In')]")).Displayed);
            Driver.FindElement(By.XPath("//div//a[contains(text(),'Log In')]")).Click();
            wait.Until(webDriver => webDriver.FindElement(By.XPath("//iframe[@class='_25r3t_lrPF3M6zD2YkWvZU']")).Displayed);
            Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@class='_25r3t_lrPF3M6zD2YkWvZU']")));
            wait.Until(webDriver => webDriver.FindElement(By.XPath("//input[@id='loginUsername']")).Displayed);
            Driver.FindElement(By.XPath("//input[@id='loginUsername']")).SendKeys("Hellraze1");
            Driver.FindElement(By.XPath("//input[@id='loginPassword']")).SendKeys("382982ff");
            Driver.FindElement(By.XPath("(//fieldset//button)[1]")).Click();

        }

        [Test]
        [Category("parallelTests")]
        public void SeleniumGoogleSearch()
        {

            Driver = new ChromeDriver();            
            Driver.Navigate().GoToUrl("https://google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            Driver.FindElement(By.Name("q")).SendKeys(Keys.Return);
            NUnit.Framework.Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true), "Selenium text not present");
        }

        [Test]
        [Category("parallelTests")]
        public void JmeterGoogleSearch()
        {

            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://google.com");
            Driver.FindElement(By.Name("q")).SendKeys("JMeter");
            Driver.FindElement(By.Name("q")).SendKeys(Keys.Return);
            NUnit.Framework.Assert.That(Driver.PageSource.Contains("Jmeter"), Is.EqualTo(true), "Jmeter text not present");
        }


        [Test]
        [ClassInitialize]
        [Category("parallelTests")]
        public void Login6()
        {
            string _appUrl = TestContext.Parameters["reddit"];
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(_appUrl);
        }


        [TearDown]
        public void teardown() {
            
            Driver.Close();
        }

    }
}
