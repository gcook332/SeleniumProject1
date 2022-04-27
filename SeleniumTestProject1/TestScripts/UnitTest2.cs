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

    public class UnitTest2 : ReusableMethods
    {

        ReusableMethods reusable = new ReusableMethods();
        TechListic techListic = new TechListic();
        ChromeDriver Driver;

        [Test]
        [Category("techListic")]
        public void Test1() {

            reusable.GoToURL("https://reddit.com");

        }

        [Test]
        [Category("techListic")]
        public void Test2() {
            reusable.GoToURL("https://techlistic.com/p/selenium-practice-form.html");
            techListic.signup("muadib", "chosenOne", "12/12/12");
            



        
        }

        [Test]
        [Category("techListic")]
        public void Test3()
        {

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.Navigate().GoToUrl("https://techlistic.com/p/selenium-practice-form.html");
            //reusable.GoToURL("https://techlistic.com/p/selenium-practice-form.html");
            //techListic.signup("muadib", "chosenOne", "12/12/12");
            wait.Until(webDriver => webDriver.FindElement(By.XPath("//div//input[@name='firstname']")).Displayed);
            Driver.FindElement(By.XPath("//div//input[@name='firstname']")).SendKeys("muadib");
            Driver.FindElement(By.XPath("//div//input[@name='lastname']")).SendKeys("chosenone");
            Driver.FindElement(By.XPath("//div//input[@id='sex-0']")).Click();
            Driver.FindElement(By.XPath("//div//input[@id='datepicker']")).SendKeys("12/12/12");




        }




    }
}
