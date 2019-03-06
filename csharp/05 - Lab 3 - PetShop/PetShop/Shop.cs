using System.Collections.Generic;
using System.Collections.Immutable;

namespace PetShop
{
    public class Shop
    {
        private ISet<string> _itemList = new HashSet<string>();

        public void AddItem(string item) => _itemList.Add(item);  

        public ISet<string> ItemsInShop => _itemList.ToImmutableHashSet();
    }
}
