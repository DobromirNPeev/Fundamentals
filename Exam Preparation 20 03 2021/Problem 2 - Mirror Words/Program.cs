using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem_2___Mirror_Words
{
    class Words
    {
        public string FirstWord { get; set; }
        public string SecondWord { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string reg = @"(?<match>(?<delimiter>[\#|\@])(?<firstWord>[A-Za-z]{3,})\2\2(?<secondWord>[A-Za-z]{3,})\2)";
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, reg);
            List<Words> matchingPairs = new List<Words>();
            foreach  (Match item in matches)
            {
                string first = item.Groups["firstWord"].ToString();
                string second = item.Groups["secondWord"].ToString();
                char[] firstReversed = first.ToCharArray();
                Array.Reverse(firstReversed);
                string fReversed = string.Join("",firstReversed);
                char[] secondReversed = second.ToCharArray();
                Array.Reverse(secondReversed);
                string sReversed = string.Join("", secondReversed);
                if (first == sReversed || second == fReversed)
                {
                    Words currMatch = new Words
                    {
                        FirstWord = first,
                        SecondWord = second
                    };
                    matchingPairs.Add(currMatch);
                }
            }
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                if (matchingPairs.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                if (matchingPairs.Count == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {
                    Console.WriteLine("The mirror words are: ");
                    int i = 0;
                    foreach (var item in matchingPairs)
                    {
                        if (i != matchingPairs.Count - 1)
                        {
                            Console.Write($"{item.FirstWord} <=> {item.SecondWord}, ");
                            i++;
                        }
                        else
                        {
                            Console.Write($"{item.FirstWord} <=> {item.SecondWord}");
                            i++;
                        }
                    }
                }
            }
        }
    }
}
