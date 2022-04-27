using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumTestProject1.Configuration;

namespace SeleniumTestProject1.TestScripts
{
    class redditTests : ReusableMethods
    {

        ChromeDriver Driver;
        

        [SetUp]
        public void Setup()
        {

            ChromeOptions Options = new ChromeOptions();
            Options.AddArguments("--disable-notifications");
            Driver = new ChromeDriver(Options);
            Driver.Manage().Window.Maximize();            
        }


        [Test]
        [Category("reddit")]
        public void Login() {

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
        [Category("reddit")]
        public void Login2()
        {
            ReusableMethods RM = new ReusableMethods();

            Driver.Navigate().GoToUrl("https://reddit.com");
            RM.RedditLoginClick();
        }

        [TearDown]
        public void teardown() {
            //Driver.Close();
        }

    }
}
