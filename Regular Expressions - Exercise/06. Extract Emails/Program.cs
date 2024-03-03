using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
           // string pattern = @"(?<user>(?!\*\-_)+[A-Za-z0-9]+[\.\-_]?[A-Za-z0-9]+)\@(?<host>[^.][A-Za-z-.]+\.[A-Z-a-z-]+)";
            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";
            string input = Console.ReadLine();
            if (char.IsLetterOrDigit(input[0]))
            {
                MatchCollection emails = Regex.Matches(input, pattern);
                foreach (var item in emails)
                {
                    Console.WriteLine(item.ToString());
                }
            }

        }
    }
}
