namespace RPG1
{
    class Item
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int Heal { get; set; }

        public static string GetItemName(int id)
        {
            switch (id)
            {
                case 1:
                    return "Wooden Sword";
                case 2:
                    return "Wooden Shield";
                case 3:
                    return "Normal Potion";
                case 4:
                    return "Rusty Dagger";
                case 5:
                    return "Goblin Ear";
                case 6:
                    return "Dragon Scale";
                default:
                    throw new NotValidID();
            }
        }

        public static string GetItemType(int id)
        {
            switch (id)
            {
                case 1:
                    return "Weapon";
                case 2:
                    return "Armor";
                case 3:
                    return "Consumable";
                case 4:
                    return "Weapon";
                case 5:
                    return "Resource";
                case 6:
                    return "Resource";
                default:
                    throw new NotValidID();
            }
        }

        public static int GetItemValue(int id)
        {
            switch (id)
            {
                case 1:
                    return 10;
                case 2:
                    return 10;
                case 3:
                    return 10;
                case 4:
                    return 15;
                case 5:
                    return 5;
                case 6:
                    return 30;
                default:
                    throw new NotValidID();
            }
        }

        public static int GetItemDamage(int id)
        {
            switch (id)
            {
                case 1:
                    return 5;
                case 2:
                    return 0;
                case 3:
                    return 0;
                case 4:
                    return 10;
                case 5:
                    return 0;
                case 6:
                    return 0;
                default:
                    throw new NotValidID();
            }
        }

        public static int GetItemDefense(int id)
        {
            switch (id)
            {
                case 1:
                    return 0;
                case 2:
                    return 5;
                case 3:
                    return 0;
                case 4:
                    return 0;
                case 5:
                    return 0;
                case 6:
                    return 0;
                default:
                    throw new NotValidID();
            }
        }

        public static int GetItemHeal(int id)
        {
            switch (id)
            {
                case 1:
                    return 0;
                case 2:
                    return 0;
                case 3:
                    return 10;
                case 4:
                    return 0;
                case 5:
                    return 0;
                case 6:
                    return 0;
                default:
                    throw new NotValidID();
            }
        }
    }
}