using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2._Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = @"\d+";
            string symbols = @"[^\d]+";
            string input = Console.ReadLine();
            MatchCollection numbersCount = Regex.Matches(input, numbers);
            MatchCollection symbolsCount = Regex.Matches(input, symbols);
            StringBuilder edited = new StringBuilder();
            List<string> uniques = new List<string>();
            for (int i = 0; i < numbersCount.Count; i++)
            {
                if (symbolsCount[i].ToString().Length == 1)
                {
                    if (!uniques.Contains(symbolsCount[i].ToString().ToLower()))
                    {
                        uniques.Add(symbolsCount[i].ToString().ToLower());
                    }
                    for (int j = 0; j < int.Parse(numbersCount[i].ToString()); j++)
                    {
                        edited.Append(symbolsCount[i].ToString().ToUpper());
                    }
                }
                else
                {
                    string current = symbolsCount[i].ToString();
                    string currentEdited = string.Empty;
                    for (int k = 0; k < current.Length; k++)
                    {
                        if (char.IsLetter(current[k]))
                        {
                            currentEdited += current[k].ToString().ToUpper();
                        }
                        else
                        {
                            currentEdited += current[k].ToString();
                        }
                    }
                    for (int k = 0; k < int.Parse(numbersCount[i].ToString()); k++)
                    {
                        edited.Append(currentEdited.ToString());
                    }
                }
            }
            Console.WriteLine($"Unique symbols used: {edited.ToString().Distinct().Count()}");
            Console.WriteLine(edited.ToString());
        }
    }
}
