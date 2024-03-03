using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            int wonCount = 0;
            bool fail = false;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(input);
                if (distance>initialEnergy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonCount} won battles and {initialEnergy} energy");
                    fail = true;
                    break;
                }
                initialEnergy -= distance;
                wonCount++;
                if (wonCount % 3 == 0)
                {
                    initialEnergy += wonCount;
                }
            }
            if (!fail)
            {
                Console.WriteLine($"Won battles: {wonCount}. Energy left: {initialEnergy}");
            }
        }
    }
}
