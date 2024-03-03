using System;

namespace _13._Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            if (int.TryParse(n, out int value))
            {
                Console.WriteLine("digit");
            }
            else if (n.Contains("a"))
            {
                Console.WriteLine("vowel");
            }
            else if (n.Contains("e"))
            {
                Console.WriteLine("vowel");
            }
            else if (n.Contains("i"))
            {
                Console.WriteLine("vowel");
            }
            else if (n.Contains("o"))
            {
                Console.WriteLine("vowel");
            }
            else if (n.Contains("u"))
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
