namespace RPG1
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Damage { get; set; }
        public int[,] Inventory { get; set; }

        public Player(string name, Breed breed)
        {
            Name = name;
            Health = breed.Health;
            Mana = breed.Mana;
            Damage = breed.Damage;
            Inventory = new int[10, 2];
        }

        public void AddItemToInventory(int itemID, int quantity)
        {
            for (int i = 0; i < Inventory.GetLength(0); i++)
            {
                if (Inventory[i, 0] == itemID)
                {
                    Inventory[i, 1] += quantity;
                    return;
                }
                if (Inventory[i, 0] == 0)
                {
                    Inventory[i, 0] = itemID;
                    Inventory[i, 1] = quantity;
                    return;
                }
            }
            Console.WriteLine("Inventory is full!");
        }

        public void DisplayInventory()
        {
            Console.WriteLine("Inventory:");
            for (int i = 0; i < Inventory.GetLength(0); i++)
            {
                if (Inventory[i, 0] != 0)
                {
                    Console.WriteLine($"Item name: {Item.GetItemName(i)}Item ID: {Inventory[i, 0]}, Quantity: {Inventory[i, 1]}");
                }
            }
        }
    }
}