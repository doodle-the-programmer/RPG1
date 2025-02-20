namespace RPG1
{
    public static class PlayerCreation
    {
        public static Player CreatePlayer()
        {
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Welcome, {playerName}!");
            Console.WriteLine("What is your breed?");
            Console.WriteLine("1. Human");
            Console.WriteLine("2. Elf");
            Console.WriteLine("3. Dwarf");
            string breedChoice = Console.ReadLine();
            Console.Clear();
            Player player;
            if (breedChoice == "1")
            {
                player = new Player(playerName, new Human());
                Console.WriteLine($"You are a Human with {player.Health} health, {player.Mana} mana, and {player.Damage} damage.");
            }
            else if (breedChoice == "2")
            {
                player = new Player(playerName, new Elf());
                Console.WriteLine($"You are an Elf with {player.Health} health, {player.Mana} mana, and {player.Damage} damage.");
            }
            else if (breedChoice == "3")
            {
                player = new Player(playerName, new Dwarf());
                Console.WriteLine($"You are a Dwarf with {player.Health} health, {player.Mana} mana, and {player.Damage} damage.");
            }
            else
            {
                throw new NotValidBreed();
            }
            return player;
        }
    }
}