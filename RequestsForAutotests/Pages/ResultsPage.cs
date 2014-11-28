using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace RequestsForAutotests.Pages
{
    public class ResultsPage : MainPage
    {
        private string _itemInListSelector = "//ul[@id='ListViewInner']/li[{0}]/h3/a";

        public void ClickItemByNumber(string number)
        {
            var itemSelector = By.XPath(string.Format(_itemInListSelector, number));
            Driver.WaitUntilElementIsClickable(itemSelector);
            Driver.FindElement(itemSelector).Click();
        }
    }
}
