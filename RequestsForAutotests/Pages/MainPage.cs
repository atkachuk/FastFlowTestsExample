using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace RequestsForAutotests.Pages
{
    public class MainPage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "#gh-ac")]
        private IWebElement SearchArea { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#gh-btn")]
        private IWebElement SearchButton { get; set; }

        public void SearchFor(string text)
        {
            SearchArea.SendKeys(text);
            SearchButton.Click();
        }
    }
}
