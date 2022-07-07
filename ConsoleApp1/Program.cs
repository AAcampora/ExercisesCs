using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order("test");
            var customer = new Customer(1, "Rob", order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            customer.Orders.Add(new Order("test 2"));
            foreach (var item in customer.Orders)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}