using System;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 1; i <= lines; i++)
            {
                var inputParts = Console.ReadLine().Split(' ');
                string left = inputParts[0];
                string right = inputParts[1]; 
                long sum = 0;
                if (long.Parse(left) >= long.Parse(right))
                {
                    left = Math.Abs(long.Parse(left)).ToString();
                    for (int j = 0; j < left.Length; j++)
                    {
                        sum += long.Parse(left[j].ToString());
                    }
                    Console.WriteLine(sum);
                }
                else if(long.Parse(right) >long.Parse(left))
                {
                    right = Math.Abs(long.Parse(right)).ToString();
                    for (int j = 0; j < right.Length; j++)
                    {
                        sum += long.Parse(right[j].ToString());
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
