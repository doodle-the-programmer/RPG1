namespace RPG1
{
    public class Breed
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Damage { get; set; }

        public Breed(int health, int mana, int damage)
        {
            Health = health;
            Mana = mana;
            Damage = damage;
        }
    }

    class Human : Breed
    {
        public Human() : base(100, 100, 10) { }
    }

    class Elf : Breed
    {
        public Elf() : base(120, 150, 8) { }
    }

    class Dwarf : Breed
    {
        public Dwarf() : base(70, 50, 20) { }
    }
}