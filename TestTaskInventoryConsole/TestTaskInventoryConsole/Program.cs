// See https://aka.ms/new-console-template for more information

using TestTaskInventoryConsole;

ItemCollection table = new ItemCollection();
ItemCollection inventory = new ItemCollection();
ItemsTransmiter transmiter = new ItemsTransmiter();

table.Add(new Item("Амулет", 1));
table.Add(new StackableItem("Монеты", 2, 33));
table.Add(new Item("Книга", 3));

ShowGameState(table, inventory);

while (table.Items.Count > 0)
{
    Console.WriteLine("Какой предмет взять?");
    string? number = Console.ReadLine();
    int index;
    if(int.TryParse(number, out index))
    {
        if(index > 0 && index <= table.Items.Count)
        {
            IItem target = table.Items[index - 1];
            transmiter.Move(target, table, inventory);
        }
    }

    ShowGameState(table, inventory);
}

Console.WriteLine("");
Console.WriteLine("На столе больше нет предметов");

static void ShowGameState(ItemCollection table, ItemCollection inventory)
{
    Console.WriteLine("Предметы на столе:");
    ShowItemsCollection(table);
    Console.WriteLine("");
    Console.WriteLine("Предметы в инвентаре:");
    ShowItemsCollection(inventory);
    Console.WriteLine("");
}

static void ShowItemsCollection(ItemCollection collection)
{
	int index = 0;
	foreach (var item in collection.Items)
	{
		index++;
		Console.WriteLine($"{index}. {item.DisplayedName}");
	}
}