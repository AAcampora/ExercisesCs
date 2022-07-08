
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            var numParsed = int.TryParse("abc", out num);
            string result = numParsed ? num.ToString() : "Conversion failed";
            Console.WriteLine(result);
        }

        static void UseParams()
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Add(1, 2));
            Console.WriteLine(calc.Add(1, 2, 3));
            Console.WriteLine(calc.Add(1, 2, 5));
            Console.WriteLine(calc.Add(new int[] { 1, 2, 3, 5, 7 }));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point = point.Move(20, 40);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point = point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {

                Console.WriteLine("Unexpected Error Occured");
            }
        }
    }
}