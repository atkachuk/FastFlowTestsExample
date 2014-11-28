using System;
using System.Net;
using OpenQA.Selenium.Remote;
using RestSharp;

namespace RequestsForAutotests.Steps
{
    class FastAddToCart : IExecutableStep
    {
        private RemoteWebDriver _driver;
        public Product Product { get; set; }

        public FastAddToCart(RemoteWebDriver driver)
        {
            _driver = driver;
        }

        public void Execute()
        {
            var client = new RestClient(UrlProvider.MainPageUrl);
            client.CookieContainer = new CookieContainer();

            var request = new RestRequest { Method = Method.GET };
            client.Execute(request);

            client.BaseUrl = new Uri(UrlProvider.CartBaseUrl);
            var addRequest = new RestRequest(UrlProvider.AddToCartUrl);
            addRequest.AddParameter("ssPageName", "CART:ATC");
            addRequest.AddParameter("item", string.Format("iid:{0},qty:1", Product.Id));
            request.Method = Method.GET;
            var addResponse = client.Execute(addRequest);

            foreach (var cookie in addResponse.Cookies)
            {
                _driver.Manage().Cookies.AddCookie(new OpenQA.Selenium.Cookie(cookie.Name, cookie.Value));
            }

            _driver.Navigate().GoToUrl(addResponse.ResponseUri);
        }
    }
}
