namespace TestTaskInventoryConsole
{
    internal class StackableItem : IItem, IStackable
    {
        private string _name;
        private int _id;
        private int _count;

        public string Name => _name;
        public string DisplayedName => $"{_count} {_name}";
        public int Id => _id;
        public int Count => _count;

        public StackableItem(string name, int id, int count)
        {
            _name = name;
            _id = id;
            _count = count;
        }

        public void Add(int count) => _count += count;

        public void Accept(IItemVisitor itemsLogic) => itemsLogic.Accept(this);
    }
}
