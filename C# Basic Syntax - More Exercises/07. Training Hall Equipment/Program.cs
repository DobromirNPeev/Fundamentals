using System;

namespace _07._Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                string itemName = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());
                if (count > 1)
                {
                    itemName += "s";
                }
                Console.WriteLine($"Adding {count} {itemName} to cart.");
                sum += price * count;
            }
            Console.WriteLine($"Subtotal: ${sum:f2}");
            if (sum > budget)
            {
                Console.WriteLine($"Not enough. We need ${sum-budget:f2} more.");
            }
            else
            {
                Console.WriteLine($"Money left: ${budget-sum:f2}");
            }
        }
    }
}
