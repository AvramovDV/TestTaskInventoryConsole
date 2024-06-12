namespace TestTaskInventoryConsole
{
    internal interface IItem
    {
        public string Name { get; }
        public string DisplayedName { get; }
        public int Id { get; }
        public void Accept(IItemVisitor itemslogic);
    }
}
