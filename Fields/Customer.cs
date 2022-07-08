
namespace Fields
{
    public sealed class Customer
    {
        public Customer(int id)
        {
            ID = id;
        }

        public Customer(int id, string name) : this(id)
        {
            Name = name;
        }

        public string Name { get;}
        public int ID { get;}

        public readonly List<Order> Orders = new List<Order>();

        public void Promote()
        {
           
        }
    }
}