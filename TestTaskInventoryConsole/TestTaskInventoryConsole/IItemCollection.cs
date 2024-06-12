namespace TestTaskInventoryConsole
{
    internal interface IItemCollection<T>
    {
        public IReadOnlyList<T> Items { get; }
        public void Add(T item);
        public void Remove(T item);
    }
}
