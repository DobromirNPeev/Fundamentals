using System;

namespace _05._Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy= int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.Write($"Health: |");
            for (int i = 1; i <= currentHealth; i++)
            {
                Console.Write("|");
            }
            for (int i = currentHealth; i < maxHealth; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("|");
            Console.Write($"Energy: |");
            for (int i = 1; i <= currentEnergy; i++)
            {
                Console.Write("|");
            }
            for (int i = currentEnergy; i < maxEnergy; i++)
            {
                Console.Write(".");
            }
            Console.Write("|");
        }
    }
}
