using OpenQA.Selenium.Remote;
using RequestsForAutotests.Pages;

namespace RequestsForAutotests.Steps
{
    public class AddToCart : IExecutableStep
    {
        private RemoteWebDriver _driver;

        public AddToCart(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        public void Execute()
        {
            var itemDetailsPage = _driver.NowHere<ItemDetailsPage>();
            itemDetailsPage.AddToCArt();
        }
    }
}
