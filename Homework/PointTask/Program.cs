using System.Net;

namespace PointTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point<double> point1 =new Point<double>();

            point1.X = 1.5;
            point1.Y = 2.5;
            Console.WriteLine($"x:{point1.X} y:{point1.Y}");

            Console.WriteLine("Swap:");
            point1.Swap();
            Console.WriteLine($"x:{point1.X} y:{point1.Y}");

            Point<double> point2 = new Point<double>();

            point2.X = 4.5;
            point2.Y = 6.5;

            Point<double> midPoint = Point<double>.Midpoint(point1, point2);

            Console.WriteLine($"Midpoint: ({midPoint.X}, {midPoint.Y})");
        }

    }
}
