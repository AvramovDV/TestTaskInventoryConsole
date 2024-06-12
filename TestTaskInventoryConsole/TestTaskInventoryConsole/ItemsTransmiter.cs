namespace TestTaskInventoryConsole
{
    internal class ItemsTransmiter : IItemVisitor
    {
        private IItemCollection<IItem> _from, _to;

        public void Move(IItem item, IItemCollection<IItem> from, IItemCollection<IItem> to)
        {
            _from = from;
            _to = to;

            item.Accept(this);
        }

        public void Accept(Item item)
        {
            _from.Remove(item);
            _to.Add(item);
        }
        public void Accept(StackableItem item)
        {
            Console.WriteLine("Сколько?");
            string? number = Console.ReadLine();
            int count;
            if (int.TryParse(number, out count))
            {
                if (count < 0)
                    return;

                count = count > item.Count ? item.Count : count;

                item.Add(-count);
                if (item.Count <= 0)
                    _from.Remove(item);

                IStackable? stackable = _to.Items.FirstOrDefault(x => x.Id == item.Id) as IStackable;

                if ((stackable == null))
                    _to.Add(new StackableItem(item.Name, item.Id, count));
                else
                    stackable.Add(count);
            }
        }
    }
}
