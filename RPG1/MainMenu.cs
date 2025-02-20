namespace RPG1
{
    public static class MainMenu
    {
        public static void DisplayMainMenu(Player player)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. View Inventory");
                Console.WriteLine("2. View Stats");
                Console.WriteLine("3. Choose Mission");
                Console.WriteLine("4. Exit");
                int choice = GetValidInput();
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        player.DisplayInventory();
                        break;
                    case 2:
                        ViewStats(player);
                        break;
                    case 3:
                        ChooseMission(player);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
            }
        }

        private static void ViewStats(Player player)
        {
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Health: {player.Health}");
            Console.WriteLine($"Mana: {player.Mana}");
            Console.WriteLine($"Damage: {player.Damage}");
        }

        private static void ChooseMission(Player player)
        {
            Console.WriteLine("Choose a mission:");
            Console.WriteLine("1. Mission 1");
            int missionChoice = GetValidInput();
            Console.Clear();
            switch (missionChoice)
            {
                case 1:
                    Mission1(player);
                    break;
                default:
                    Console.WriteLine("Invalid mission choice.");
                    break;
            }
        }

        private static void Mission1(Player player)
        {
            Console.Clear();
            Console.WriteLine("You are walking through the forest when you encounter a Bum.");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. Fight");
            Console.WriteLine("2. Run");
            int choice = GetValidInput();
            Console.Clear();
            switch (choice)
            {
                case 1:
                    Fight.StartFight(player, new Bum());
                    break;
                case 2:
                    Console.WriteLine("You run away.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
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