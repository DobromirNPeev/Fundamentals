using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char letter1 = (char)(i + 97);
                for (int j = 0; j < n; j++)
                {
                    char letter2 = (char)(j + 97);
                    for (int k = 0; k < n; k++)
                    {
                        char letter3 = (char)(k + 97);
                        Console.WriteLine($"{letter1}{letter2}{letter3}");
                    }
                }
            }
        }
    }
}
