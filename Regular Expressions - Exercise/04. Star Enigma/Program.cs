using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string star = @"[starSTAR]";
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();
            int n = int.Parse(Console.ReadLine());
            string attackType = string.Empty;
            string planet = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection starReg = Regex.Matches(input, star);
                string changed = string.Empty;
                for (int j = 0; j < input.Length; j++)
                {
                    char curr = (char)((int)input[j] - starReg.Count);
                    changed += curr;
                }
                string reg = @"\@(?<planetName>[A-Z][a-z]+)[^@\-!:>]*?:(?<population>\d+)[^@\-!:>]*?\!(?<attackType>[AD])\![^@\-!:>]*?\-\>(?<soldierCount>\d+)";
                MatchCollection change = Regex.Matches(changed, reg);
                if (Regex.IsMatch(changed, reg))
                {
                    attackType = change[0].Groups["attackType"].ToString();
                    planet = change[0].Groups["planetName"].ToString();
                }
                else
                {
                    continue;
                }
                if (attackType == "A")
                {
                    attacked.Add(planet);
                }
                else
                {
                    destroyed.Add(planet);
                }
            }
            attacked = attacked.OrderBy(x => x).ToList();
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (var item in attacked)
            {
                Console.WriteLine($"-> {item}");
            }
            destroyed = destroyed.OrderBy(x => x).ToList();
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (var item in destroyed)
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
