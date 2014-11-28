using OpenQA.Selenium.Remote;

namespace RequestsForAutotests.Steps
{
    class NavigateToMarket : IExecutableStep
    {
        private RemoteWebDriver _driver;

        public NavigateToMarket(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        public void Execute()
        {
            _driver.Navigate().GoToUrl(UrlProvider.MainPageUrl);
        }
    }
}
