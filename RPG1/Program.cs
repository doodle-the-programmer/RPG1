namespace RPG1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Player player = PlayerCreation.CreatePlayer();
            Console.Clear();
            MainMenu.DisplayMainMenu(player);
        }
    }
}