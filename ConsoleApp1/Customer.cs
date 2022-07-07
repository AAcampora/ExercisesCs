using System.Collections.Generic;

namespace ConsoleApp1
{

    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }
        //redundat constructors as they really don't need
        //initialization
        //call previous constructor and set Id 
        public Customer(int id) : this()
        {
            this.Id = id;
        }
        //call previous constructor and set name
        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }
    }
}