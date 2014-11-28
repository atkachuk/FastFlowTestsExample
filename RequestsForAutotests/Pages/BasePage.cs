using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace RequestsForAutotests.Pages
{
    public class BasePage
    {
        public RemoteWebDriver Driver { get; set; }

        public void InitElements()
        {
            PageFactory.InitElements(Driver, this);
        }
    }
}
