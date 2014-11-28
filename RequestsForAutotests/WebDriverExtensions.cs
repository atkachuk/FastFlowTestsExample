using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RequestsForAutotests.Pages;

namespace RequestsForAutotests
{
    public static class WebDriverExtensions
    {
        public static T NowHere<T>(this RemoteWebDriver driver) where T : BasePage, new()
        {
            Logger.Log("Now at " + typeof(T).Name);
            var page = new T { Driver = driver};
            page.InitElements();
            return page;
        }

        private static Func<IWebDriver, IWebElement> ElementIsClickable(By by)
        {
            return driver =>
            {
                var element = driver.FindElement(by);
                return (element != null && element.Displayed && element.Enabled) ? element : null;
            };
        }

        private static Func<IWebDriver, IWebElement> ElementIsClickable(IWebElement element)
        {
            return driver => (element != null && element.Displayed && element.Enabled) ? element : null;
        }

        /// <summary>
        /// An expectation for checking whether an element is clickable.
        /// </summary>
        public static void WaitUntilElementIsClickable(this RemoteWebDriver driver, By by)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ElementIsClickable(by));
        }

        /// <summary>
        /// An expectation for checking whether an element is clickable.
        /// </summary>
        public static void WaitUntilElementIsClickable(this RemoteWebDriver driver, IWebElement element)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(ElementIsClickable(element));
        }
    }
}
