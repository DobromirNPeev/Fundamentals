using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int waterTank = 0;
            for (int i = 1; i <=n; i++)
            {
                int liter = int.Parse(Console.ReadLine());
                waterTank += liter;
                if (waterTank > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    waterTank -= liter;
                }
            }
            Console.WriteLine(waterTank);
        }
    }
}
