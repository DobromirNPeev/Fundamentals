using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] zizZag1 = new int[n];
            int[] zizZag2 =new int[n];
            for (int i = 0; i <n; i++)
            {
                int[] currentRow= Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int firstArray = currentRow[0];
                int secondArray =currentRow[1];
                if (i % 2 == 0)
                {
                    zizZag1[i] = firstArray;
                    zizZag2[i] = secondArray;
                }
                else if (i % 2 == 1)
                {
                    zizZag1[i] = secondArray;
                    zizZag2[i] = firstArray;
                }
            }
            Console.WriteLine(string.Join(" ",zizZag1));
            Console.WriteLine(string.Join(" ",zizZag2));
        }
    }
}
