using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string @string = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string newString = Connect(@string, n);
            Console.WriteLine(newString);
        }
        static string Connect(string @string,int n)
        {
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                result += @string;
            }
            return result;
        }
    }
}
