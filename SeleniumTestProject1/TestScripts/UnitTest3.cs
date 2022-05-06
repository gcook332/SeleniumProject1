using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumTestProject1.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestProject1.TestScripts
{
    
    class UnitTest3 : ReusableMethods {


        [Test]
        public void OpenBrowser()
        {

            OpenBrowser(TestContext.Parameters["DefaultExecutiontype"]);
            
            
        }



    }
}
