namespace RPG1
{
    public class Fight
    {
        public static void StartFight(Player player, Character enemy)
        {
            Console.Clear();
            Console.WriteLine($"You are fighting a {enemy.Name}!");
            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine($"Your health: {player.Health}, enemy health: {enemy.Health}");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Use item");
                Console.WriteLine("3. Run");
                int choice = GetValidInput();
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        enemy.Health -= player.Damage;
                        player.Health -= enemy.Damage;
                        break;
                    case 2:
                        player.DisplayInventory();
                        Console.WriteLine("Enter item ID:");
                        int itemID = GetValidInput();
                        Console.WriteLine("Enter quantity:");
                        int quantity = GetValidInput();
                        player.AddItemToInventory(itemID, quantity);
                        break;
                    case 3:
                        Console.WriteLine("You ran away!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            if (player.Health <= 0)
            {
                Console.WriteLine("You died!");
            }
            else
            {
                Console.WriteLine($"You defeated the {enemy.Name}!");
                if (new Random().NextDouble() < enemy.DropChance)
                {
                    player.AddItemToInventory(enemy.DropItemID, enemy.DropQuantity);
                    Console.WriteLine($"You got: {enemy.DropQuantity} x {Item.GetItemName(enemy.DropItemID)}!");
                }
            }
        }

        private static int GetValidInput()
        {
            int choice;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out choice))
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}