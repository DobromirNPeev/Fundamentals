using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int toTheRight = 0;
            int big = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                toTheRight = i+1;
                if (arr[i] > arr[toTheRight])
                {
                    while (arr[i] > arr[toTheRight] && toTheRight<arr.Length-1)
                    {
                        toTheRight++;
                    }
                    if (arr[i] > arr[toTheRight] && toTheRight==arr.Length-1)
                    {
                        big = arr[i];
                        Console.Write($"{big} ");
                    }
                }
            }
            Console.WriteLine($"{arr[arr.Length-1]}");
        }
    }
}
