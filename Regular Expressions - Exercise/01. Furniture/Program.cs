using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            Regex regex = new Regex(pattern);
            List<string> furnitures = new List<string>();
            decimal sum = 0;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                MatchCollection matched = Regex.Matches(input, pattern);
                if (Regex.IsMatch(input, pattern))
                {
                    foreach (Match m in matched)
                    {
                        var name = m.Groups["furniture"].Value;
                        var price = decimal.Parse(m.Groups["price"].Value);
                        var quant = int.Parse(m.Groups["quantity"].Value);
                        furnitures.Add(name);
                        sum += price * quant;
                    }
                }
            }
            Console.WriteLine("Bought furniture:");
            if (furnitures.Count > 0)
            {
                foreach (var item in furnitures)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
