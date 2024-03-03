using System;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string values1 = Console.ReadLine();
            string[] Array = values1.Split();
            int n = int.Parse(Console.ReadLine());
            var temp = Array[0];
            for (int i = 0; i < n; i++)
            {
                temp = Array[0];
                for (int j = 0; j < Array.Length - 1; j++)
                {
                    Array[j] = Array[j + 1];
                }
                Array[Array.Length - 1] = temp;
            }
            Console.WriteLine(string.Join(" ",Array));
        }
    }
}
