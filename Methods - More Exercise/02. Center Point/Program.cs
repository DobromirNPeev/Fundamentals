using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            if (hypotenuseCalculate(x1,y1)<= hypotenuseCalculate(x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
        static double hypotenuseCalculate(double x1,double y1)
        {
            x1 = Math.Abs(x1);
            y1 = Math.Abs(y1);
            double hypotenuse = Math.Sqrt((x1 * x1) + (y1 * y1));
            return hypotenuse;
        }
    }
}
