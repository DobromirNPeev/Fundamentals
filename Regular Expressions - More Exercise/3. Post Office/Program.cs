using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3._Post_Office
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries);
            string firstPart = input[0];
            string secondPart = input[1];
            string[] thirdPart = input[2].Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string firstReg = @"([#$%*&])[A-z]+\1";
            string secondReg = @"(?<ascii>[6-9][0-9])\:(?<length>[0-9]{2})";
            Dictionary<string, int> props = new Dictionary<string, int>();
            List<string> words = new List<string>();
            MatchCollection firstParts = Regex.Matches(firstPart, firstReg);
            MatchCollection secondParts = Regex.Matches(secondPart, secondReg);
            List<string> clean = new List<string>();
            foreach (var item in firstParts)
            {
                string itemAsString = item.ToString();
                for (int i = 0; i < itemAsString.Length; i++)
                {
                    if (char.IsUpper(itemAsString[i]))
                    {
                        clean.Add(itemAsString[i].ToString());
                    }
                }
            }
            foreach (var item in secondParts)
            {
                string[] current = item.ToString().Split(':');
                int asciiCode = int.Parse(current[0]);
                int length = int.Parse(current[1]);
                for (int i = 0; i < clean.Count; i++)
                {
                    if (char.Parse(clean[i]) == asciiCode)
                    {
                        if (!props.ContainsKey(clean[i].ToString()))
                        {
                            props.Add(clean[i].ToString(), length);
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < thirdPart.Length; i++)
            {
                string current = thirdPart[i];
                foreach (var item in props)
                {
                    if(current[0].ToString()==item.Key && current.Length == item.Value + 1)
                    {
                        words.Add(current);
                    }
                }
            }
            for (int i = 0; i < clean.Count; i++)
            {
                for (int j = 0; j < words.Count; j++)
                {
                    string currentWord = words[j];
                    char firstLetter = currentWord[0];
                    if (firstLetter == char.Parse(clean[i]))
                    {
                        Console.WriteLine(currentWord);
                        break;
                    }
                }
            }
        }
    }
}
