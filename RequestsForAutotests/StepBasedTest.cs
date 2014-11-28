using RequestsForAutotests.Steps;

namespace RequestsForAutotests
{
    public class StepBasedTest : BaseTest
    {
        protected void NavigateToMarketMainPage()
        {
            new NavigateToMarket(Driver).Execute();
        }

        protected void OpenProduct(Product product, long number)
        {
            new OpenProduct(Driver){Product = product, ResultNumber = number}.Execute();
        }

        protected void AddToCart()
        {
            new AddToCart(Driver).Execute();
        }

        protected void AsserCartPageHeaderIs(string header)
        {
            new AssertCartPageHeader(Driver){ExpectedHeader = header}.Execute();
        }

        protected void FastAddItemToCart(Product product)
        {
            new FastAddToCart(Driver) { Product = product }.Execute();
        }
    }
}
