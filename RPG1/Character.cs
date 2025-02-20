namespace RPG1
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Damage { get; set; }
        public int DropItemID { get; set; }
        public double DropChance { get; set; }
        public int DropQuantity { get; set; }

        public Character(string name, int health, int mana, int damage, int dropItemID, double dropChance, int dropQuantity)
        {
            Name = name;
            Health = health;
            Mana = mana;
            Damage = damage;
            DropItemID = dropItemID;
            DropChance = dropChance;
            DropQuantity = dropQuantity;
        }
    }

    public class Bum : Character
    {
        public Bum() : base("Bum", 10, 10, 1, 4, 0.5, 1) { }
    }

    public class Goblin : Character
    {
        public Goblin() : base("Goblin", 20, 5, 5, 5, 0.3, 2) { }
    }

    public class Dragon : Character
    {
        public Dragon() : base("Dragon", 100, 50, 20, 6, 0.1, 3) { }
    }
}