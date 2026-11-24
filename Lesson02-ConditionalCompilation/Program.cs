using Leccion01Partial;

Inventory inventory = new Inventory();
inventory.Add("Sword");
inventory.Add("Shield");
inventory.Add("Potion");

#if DEBUG
inventory.PrintAll();
#endif

Console.WriteLine("Inventory ready");