using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTestProject1
{
    public class Tests{
        String test_url_reddit = "https://www.reddit.com";
        String test_url_reddit_login = "https://www.reddit.com/login/?experiment_d2x_2020ify_buttons=enabled&experiment_d2x_sso_login_link=enabled";
        String test_url_google = "https://google.com";

        IWebDriver Driver;


        [SetUp]
        public void Setup()
        {
            ChromeOptions Options = new ChromeOptions();
            Options.AddArguments("--disable-notifications");
            Driver = new ChromeDriver(Options);


            Driver.Manage().Window.Maximize();
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10)); wait object to be used
        }

        [Test]
        public void Test1(){


            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            Driver.Url = test_url_reddit;
            //Driver.Navigate().GoToUrl("https://www.reddit.com/login/?experiment_d2x_2020ify_buttons=enabled&experiment_d2x_sso_login_link=enabled");
            
 
            wait.Until(webDriver => webDriver.FindElement(By.XPath("//*[@id='loginUsername']")).Displayed); //waits for element to show up

            //Driver.FindElement(By.Id("loginUsername")).SendKeys("FuckBigDateh");


        }

        [Test]
        public void Test2(){
            Driver.Url = test_url_google;
            Driver.FindElement(By.XPath("//*[@class='gLFyf gsfi']")).SendKeys("automation scripting");
            Driver.FindElement(By.XPath("//*[@class='gLFyf gsfi']")).SendKeys(Keys.Enter);




            Driver.Url = test_url;
            Driver.FindElement(By.XPath("//*[contains(text(),'Log In')]")).Click();
           
        }

        [Test]
        public void Test3(){
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.Navigate().GoToUrl("https://www.google.com/ncr");
            Driver.FindElement(By.Name("q")).SendKeys("cheese" + Keys.Enter);
            wait.Until(webDriver => webDriver.FindElement(By.CssSelector("h3")).Displayed);
            IWebElement firstResult = Driver.FindElement(By.CssSelector("h3"));
            Console.WriteLine(firstResult.GetAttribute("textContent"));



        }

        [Test]
        public void Test4(){
            Driver.Url = test_url_reddit;
            
            Driver.FindElement(By.XPath("//*[contains(text(),'Log In')]")).Click();

            //IWebElement Loginbutton = Driver.FindElement(By.XPath("//*[contains(text(),'Log In')]"));
            //Loginbutton.Click();
            //IWebElement UserNameLogin = Driver.FindElement(By.XPath("//*[@id='loginUsername']"));
            //UserNameLogin.SendKeys("fuckbigdateh");

        }

        [Test]
        public void Test5(){

            //With the web elements it can make a difference where you put the object and the action. when declaring the signup webelement and putting it after the webelement
            //declarations it doesnt work. Need to put the objects action immediately after the declaration

            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.Url = test_url_reddit_login;
            wait.Until(webDriver => webDriver.FindElement(By.XPath("(//*[@class='BottomLink'])[1]")).Displayed);

            IWebElement signUp = Driver.FindElement(By.XPath("(//*[@class='BottomLink'])[1]"));
            signUp.Click();
            IWebElement emailField = Driver.FindElement(By.Id("regEmail"));
            emailField.SendKeys("DoctorLietKynes@gmail.com");
            wait.Until(webDriver => webDriver.FindElement(By.XPath("//*[@class='AnimatedForm__submitButton m-full-width']")).Displayed);
            IWebElement continueButton = Driver.FindElement(By.XPath("//*[@class='AnimatedForm__submitButton m-full-width']"));
            continueButton.Click();
            wait.Until(webDriver => webDriver.FindElement(By.Id("regUsername")).Displayed);
            IWebElement userNameField = Driver.FindElement(By.Id("regUsername"));
            userNameField.SendKeys("Sardaukar119");
            IWebElement userPasswordField = Driver.FindElement(By.Id("regPassword"));
            userPasswordField.SendKeys("welcome123!");
            IWebElement signUp_account_activation = Driver.FindElement(By.XPath("//*[@class='AnimatedForm__submitButton SignupButton']"));
            signUp_account_activation.Click();
            

        }

        [TearDown]
        public void Teardown() 
        {
            //Driver.Close();
        }
    }
}

public static class WebDriverExtensions
{
    public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
    {
        if (timeoutInSeconds > 0)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(drv => drv.FindElement(by));
        }
        return driver.FindElement(by);
    }
}