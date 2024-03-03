using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(\=|\/)(?<destination>[A-Z][A-Za-z]{2,})\1");
            string places = Console.ReadLine();
            MatchCollection matches = pattern.Matches(places);
            List<string> destinations = new List<string>();
            int sum = 0;
            foreach (Match item in matches)
            {
                destinations.Add(item.Groups["destination"].ToString());
                sum += item.Groups["destination"].ToString().Length;
            }
            Console.WriteLine($"Destinations: {string.Join(", ",destinations)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
