namespace TestTaskInventoryConsole
{
    internal class Item : IItem
    {
        private string _name;
        private int _id;

        public string Name => _name;
        public string DisplayedName => _name;
        public int Id => _id;

        public Item(string name, int id)
        {
            _name = name;
            _id = id;
        }

        public void Accept(IItemVisitor itemsLogic) => itemsLogic.Accept(this);
    }
}
