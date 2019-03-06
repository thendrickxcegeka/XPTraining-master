using Xunit;
using FluentAssertions;

namespace PetShop.Tests
{
    public class ShopTest
    {
        private Shop _shop;

        public ShopTest() {
            _shop = new Shop();
        }

        [Fact]
        public void AddItem_whenItem_thenAddsItemToStock()
        {
            string item = "Doggy Gucci bag";
            _shop.AddItem(item);

            _shop.ItemsInShop.Should().Contain("Doggy Gucci bag");
        }
    }
}
