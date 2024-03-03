using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            if (hypotenuseCalculate(x1, y1) + hypotenuseCalculate(x2, y2)> hypotenuseCalculate(x3, y3)+ hypotenuseCalculate(x4, y4))
            {
                if (hypotenuseCalculate(x1, y1) <= hypotenuseCalculate(x2, y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (hypotenuseCalculate(x3, y3) <= hypotenuseCalculate(x4, y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }
        static double hypotenuseCalculate(double x1, double y1)
        {
            x1 = Math.Abs(x1);
            y1 = Math.Abs(y1);
            double hypotenuse = Math.Sqrt((x1 * x1) + (y1 * y1));
            return hypotenuse;
        }
    }
}
