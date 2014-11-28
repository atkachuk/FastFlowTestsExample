using NUnit.Framework;
using OpenQA.Selenium;

namespace RequestsForAutotests.Pages
{
    public class CartPage : MainPage
    {
        private By _cartTextSelector = By.XPath("//*[@id='PageTitle']/div[2]/h2");

        public string GetPageHeader()
        {
            Driver.WaitUntilElementIsClickable(_cartTextSelector);
            return Driver.FindElement(_cartTextSelector).Text;
        }
    }
}
