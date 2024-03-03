using System;

namespace _01._Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;
            if (profession == "Athlete")
            {
                price = quantity * 0.7;
            }
            else if (profession == "SoftUni Student")
            {
                price = quantity * 1.7;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                price = quantity * 1;
            }
            else
            {
                price = quantity * 1.2;
            }
            Console.WriteLine($"The {profession} has to pay {price:f2}.");
        }
    }
}
