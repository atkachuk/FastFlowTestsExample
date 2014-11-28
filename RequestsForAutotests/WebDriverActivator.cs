using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace RequestsForAutotests
{
    public static class WebDriverActivator
    {
        public static RemoteWebDriver GetDriver()
        {
            return new FirefoxDriver();
        }
    }
}
