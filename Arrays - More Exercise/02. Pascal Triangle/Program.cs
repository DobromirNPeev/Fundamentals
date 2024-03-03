using System;
using System.Linq;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] rowArray = new int[n];
            rowArray[0] = 1;
            for (int i = 0; i < n; i++)
            {
                int clear = 0;
                while (rowArray[clear] != 0)
                {
                    Console.Write($"{rowArray[clear]} ");
                    clear++;
                    if (clear == rowArray.Length)
                    {
                        break;
                    }
                }
                int[] NextRowArray = new int[n];
                for (int j = 0; j < n; j++)
                {
                    if (j == 0)
                    {
                        NextRowArray[j] = 1;
                    }
                    else
                    {
                        NextRowArray[j] = rowArray[j - 1] + rowArray[j];
                    }
                }
                rowArray = NextRowArray;
                Console.WriteLine();
            }
        }
    }
}
