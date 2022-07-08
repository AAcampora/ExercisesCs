using System.Linq;
namespace ConsoleApp2
{
    public struct Calculator
    {
        public int Add(params int[] numbers)
        {
            int sum = 0;
            return sum += numbers.Sum();
        }
    }
}