using NUnit.Framework;
using RestSharp;
using SeleniumTestProject1.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeleniumTestProject1.TestScripts
{
    [TestFixture]
    [Parallelizable(Constants.ParallelExecutionScope)]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    class API : ReusableMethods
    {

        
    }
}
