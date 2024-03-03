using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
               int n = int.Parse(Console.ReadLine());
                if (n % 2 == 1 || n%2==-1)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(n)}");
                    break;
                }
            }
        }
    }
}
