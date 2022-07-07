namespace ConsoleApp1
{
    public sealed class Order
    {
        public Order(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}