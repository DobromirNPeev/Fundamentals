using System;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string reg = @"(?<delimiter>\||\#)(?<item>[A-Za-z ]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,5})\1";
            string input = Console.ReadLine();
            int caloriesSum = 0;
            MatchCollection matches = Regex.Matches(input, reg);
            foreach (Match item in matches)
            {
                caloriesSum += int.Parse(item.Groups["calories"].Value);
            }
            int daysCount = caloriesSum / 2000;
            Console.WriteLine($"You have food to last you for: {daysCount} days!");
            foreach (Match item in matches)
            {
                Console.WriteLine($"Item: {item.Groups["item"]}, Best before: {item.Groups["date"]}, Nutrition: {item.Groups["calories"]}");
            }
        }
    }
}
