using System;
using System.Collections.Generic;
using System.Linq;


namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            List<int> initialQuality = new List<int>();
            foreach (int number in drumSet)
            {
                initialQuality.Add(number);
            }
            string command = string.Empty;
            while((command=Console.ReadLine())!= "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);
                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= hitPower;
                    if (drumSet[i] <= 0)
                    {
                        drumSet.RemoveAt(i);
                        double price = initialQuality[i] * 3;
                        if (price < savings)
                        {
                            savings -= price;
                            drumSet.Insert(i, initialQuality[i]);
                        }
                        else
                        {
                            initialQuality.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ",drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
