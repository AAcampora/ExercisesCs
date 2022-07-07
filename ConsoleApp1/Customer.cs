using System.Collections.Generic;

namespace ConsoleApp1
{
    public sealed class Customer
    {
        public Customer(int id, string name, IList<Order> order)
        {
            Name = name;
            Id = id;
            Orders = new List<Order>();
        }
        public Customer(int id, string name, Order order)
        {
            Name = name;
            Id = id;
            Orders = new List<Order>() { order };
        }

        public int Id { get; }
        public string Name { get; }
        public List<Order> Orders { get; }
    }
}