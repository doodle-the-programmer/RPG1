namespace RPG1
{
    public class NotValidBreed : Exception
    {
        public NotValidBreed() : base("Not a valid breed.") { }
    }

    public class NotValidID : Exception
    {
        public NotValidID() : base("Not a valid item ID.") { }
    }
}