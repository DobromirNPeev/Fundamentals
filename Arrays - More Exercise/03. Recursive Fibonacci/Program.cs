using System;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] length = new int[n];
            if (length.Length == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                length[0] = 1;
                length[1] = 1;
                for (int i = 2; i < n; i++)
                {
                    length[i] = length[i - 1] + length[i - 2];
                }
                Console.WriteLine(length[length.Length - 1]);
            }
        }
    }
}
