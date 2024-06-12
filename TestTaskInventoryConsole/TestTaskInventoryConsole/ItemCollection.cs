using System;
using System.Collections.Generic;
using System.Linq;
namespace TestTaskInventoryConsole
{
    internal class ItemCollection : IItemCollection<IItem>
    {
        private List<IItem> _items = new List<IItem>();

        public IReadOnlyList<IItem> Items => _items;

        public void Add(IItem item) => _items.Add(item);
        public void Remove(IItem item) => _items.Remove(item);
    }
}
