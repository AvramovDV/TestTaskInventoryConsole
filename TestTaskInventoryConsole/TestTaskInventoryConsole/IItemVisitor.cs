namespace TestTaskInventoryConsole
{
    internal interface IItemVisitor
    {
        public void Accept(Item item);
        public void Accept(StackableItem item);
    }
}
