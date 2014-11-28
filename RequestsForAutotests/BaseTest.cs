using System.Diagnostics;
using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace RequestsForAutotests
{
    public class BaseTest
    {
        protected RemoteWebDriver Driver;
        private Stopwatch sw;

        [TestFixtureSetUp]
        public void Setup()
        {
            Driver = WebDriverActivator.GetDriver();
            sw = new Stopwatch();
            sw.Start();
        }

        [TestFixtureTearDown]
        public void Teardown()
        {
            sw.Stop();
            Logger.Log("Elapsed seconds: " + sw.Elapsed.TotalSeconds);
            Driver.Quit();
        }
    }
}
