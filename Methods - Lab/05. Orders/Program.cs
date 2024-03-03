using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            if (product == "coffee")
            {
                Price(1.50, quantity);
            }
            else if (product == "water")
            {
                Price(1, quantity);
            }
            else if (product == "coke")
            {
                Price(1.40, quantity);
            }
            else
            {
                Price(2, quantity);
            }
        }
        static void Price(double price, int quantity)
        {
            Console.WriteLine($"{price * quantity:f2}");
        }
    }
}
