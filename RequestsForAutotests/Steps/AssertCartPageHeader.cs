using NUnit.Framework;
using OpenQA.Selenium.Remote;
using RequestsForAutotests.Pages;

namespace RequestsForAutotests.Steps
{
    class AssertCartPageHeader : IExecutableStep
    {
        private RemoteWebDriver _driver;
        public string ExpectedHeader { get; set; }

        public AssertCartPageHeader(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        public void Execute()
        {
            var cartPage = _driver.NowHere<CartPage>();
            var actualText = cartPage.GetPageHeader();
            Assert.That(ExpectedHeader, Is.EqualTo(actualText));
        }
    }
}
