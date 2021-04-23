namespace NjetflixOO
{
    public class Customer
    {
        public int Id;
        public string Name;
        public bool Ismember;
        public int wallet;

        public Customer(int id, string name, bool ismember, int cash)
        {
            Id = id;
            Name = name;
            Ismember = ismember;
            wallet = cash;
        }
    }
}