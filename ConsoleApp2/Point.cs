
namespace ConsoleApp2
{
    public sealed class Point
    {
        //constructors
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        //Properties
        public int X { get;}
        public int Y { get;}
        //Methods
        public Point Move (int x, int y)
        {
            return new Point(x, y);
        }
        //Test override method
        public Point Move (Point newLocation)
        {
            if (newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }
            return Move (newLocation.X, newLocation.Y);
        }
    }

}