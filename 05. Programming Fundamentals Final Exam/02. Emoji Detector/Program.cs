using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern=new Regex(@"(([\:\:]|[\*\*])\2)[A-Z][a-z]{2,}\1");
            string input = Console.ReadLine();
            Regex digitsReg =new Regex(@"\d");
            MatchCollection matches = pattern.Matches(input);
            MatchCollection digits = digitsReg.Matches(input);
            BigInteger coolThresholdSum = 1;
            foreach (Match item in digits)
            {
                coolThresholdSum *= int.Parse(item.ToString());
            }
            Console.WriteLine($"Cool threshold: {coolThresholdSum}");
            List<string> valids = new List<string>();
            foreach (Match item in matches)
            {
                string itemAsString = item.ToString();
                string clean = string.Empty;
                int cleanSum = 0;
                for (int i = 0; i < itemAsString.Length; i++)
                {
                    if (char.IsLetter(itemAsString[i]))
                    {
                        clean += itemAsString[i];
                        cleanSum += itemAsString[i];
                    }
                }
                if (cleanSum >= coolThresholdSum)
                {
                    valids.Add(itemAsString);
                }
            }
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            foreach (var item in valids)
            {
                Console.WriteLine(item);
            }
        }
    }
}
