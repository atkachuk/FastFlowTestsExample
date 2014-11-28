using NUnit.Framework;

namespace RequestsForAutotests
{
    class cart_header_should_be_correct : StepBasedTest
    {
        [Test]
        public void DefaultTestExecution()
        {
            var product = new Product
            {
                Name = "TIMBERPRO 62cc Petrol Chainsaw, 20\" Bar & 2x Saw Chain. Alloy & Assisted Start",
                
            };

            NavigateToMarketMainPage();
            OpenProduct(product, 3);
            AddToCart();
            AsserCartPageHeaderIs("Your eBay Shopping Cart");
        }

        [Test]
        public void FastTestExecution()
        {
            var product = new Product
            {
                Id = "301198962901"
            };

            FastAddItemToCart(product);
            AsserCartPageHeaderIs("Your eBay Shopping Cart");
        }
    }
}
