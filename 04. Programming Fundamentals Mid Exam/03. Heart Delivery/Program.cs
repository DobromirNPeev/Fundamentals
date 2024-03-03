using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split('@', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string jump = string.Empty;
            int index = 0;
            while ((jump=Console.ReadLine())!="Love!")
            {
                string[] jumping = jump.Split().ToArray();
                index +=int.Parse(jumping[1]);
                if (index >= input.Length)
                {
                    index = 0;
                }
                if (input[index]==0)
                {
                    Console.WriteLine($"Place {index} already had Valentine's day.");
                }
                else
                {
                    input[index] -= 2;
                    if (input[index] == 0)
                    {
                        Console.WriteLine($"Place {index} has Valentine's day.");
                    }
                }
            }
            int housesCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 0)
                {
                    housesCount++;
                }
            }
            Console.WriteLine($"Cupid's last position was {index}.");
            if (housesCount==0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {housesCount} places.");
            }
        }
    }
}
