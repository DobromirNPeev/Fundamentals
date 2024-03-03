using System;
using System.Text.RegularExpressions;

namespace _02._Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"(\!)(?<command>[A-Z]{1}[a-z]{3,})\1\:\[(?<strToTranslate>[A-Za-z]{8,})\]";
            Regex reg = new Regex(pattern);
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (reg.IsMatch(input))
                {
                    Match curr = reg.Match(input);
                    string str = curr.Groups["strToTranslate"].ToString();
                    Console.Write($"{curr.Groups["command"].ToString()}: ");
                    foreach (var item in str)
                    {
                        Console.Write($"{(int)item} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
