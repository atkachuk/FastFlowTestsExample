namespace RequestsForAutotests
{
    public static class UrlProvider
    {
        public static string MainPageUrl
        {
            get { return "http://www.ebay.com/"; }
        }

        public static string CartBaseUrl
        {
            get { return "http://cart.payments.ebay.com"; }
        }

        public static string AddToCartUrl
        {
            get { return "/sc/add"; }
        }
    }
}
