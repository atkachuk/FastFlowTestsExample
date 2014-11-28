using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RequestsForAutotests.Pages;

namespace RequestsForAutotests.Steps
{
    public class OpenProduct : IExecutableStep
    {
        private RemoteWebDriver _driver;
        public Product Product { get; set; }
        public long ResultNumber { get; set; }

        public OpenProduct(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        public void Execute()
        {
            CloseBlackFriday();

            var mainPage = _driver.NowHere<MainPage>();
            mainPage.SearchFor(Product.Name);

            var resultsPage = _driver.NowHere<ResultsPage>();
            resultsPage.ClickItemByNumber(ResultNumber.ToString());
        }

        private void CloseBlackFriday()
        {
            var blackFridaySelector = By.CssSelector("#HomepageOverlay0314ModalClose");
            _driver.WaitUntilElementIsClickable(blackFridaySelector);
            _driver.FindElement(blackFridaySelector).Click();
        }
    }
}
