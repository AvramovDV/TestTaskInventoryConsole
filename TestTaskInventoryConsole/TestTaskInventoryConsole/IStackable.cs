namespace TestTaskInventoryConsole
{
    internal interface IStackable
    {
        public int Count { get; }

        public void Add(int count);
    }
}
