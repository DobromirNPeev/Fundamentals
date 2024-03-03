using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string values1 = Console.ReadLine();
            string[] firstArray = values1.Split();
            string values2 = Console.ReadLine();
            string[] secondArray = values2.Split();
            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (secondArray[i] == firstArray[j])
                    {
                        Console.Write($"{secondArray[i]} ");
                    }
                }
            }
        }
    }
}
