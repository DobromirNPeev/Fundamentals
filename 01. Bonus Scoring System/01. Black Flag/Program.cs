using System;

namespace _01._Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expPlunder = double.Parse(Console.ReadLine());
            double plunder = 0;
            for (int i = 1; i <= days; i++)
            {
                if (i%3==0)
                {
                    plunder += 1.5 * (double)dailyPlunder;
                }
                else
                {
                    plunder += dailyPlunder;
                }
                if (i % 5 == 0)
                {
                    plunder = plunder * 0.7;
                }
            }
            if (plunder >= expPlunder)
            {
                Console.WriteLine($"Ahoy! {plunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {plunder/expPlunder*100:f2}% of the plunder.");
            }
        }
    }
}
