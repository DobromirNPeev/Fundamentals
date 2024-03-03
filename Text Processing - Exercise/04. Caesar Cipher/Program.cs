using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (var item in input)
            {
                char improved = (char)(item+3);
                Console.Write(improved);
            }
        }
    }
}
