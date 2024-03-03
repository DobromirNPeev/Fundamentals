using System;

namespace _09._Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                var n = Console.ReadLine();
                if (int.TryParse(n, out int value))
                {
                    count++;
                }
                else
                {
                    Console.WriteLine(count);
                    break;
                }
            }
        }
    }
}
