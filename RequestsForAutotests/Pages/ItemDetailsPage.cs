using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace RequestsForAutotests.Pages
{
    class ItemDetailsPage : MainPage
    {
        [FindsBy(How = How.CssSelector, Using = "#isCartBtn_btn")]
        private IWebElement AddToCartButton { get; set; }

        public void AddToCArt()
        {
            Driver.WaitUntilElementIsClickable(AddToCartButton);
            AddToCartButton.Click();
        }
    }
}
