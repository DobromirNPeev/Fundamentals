using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string CapnameRegex = @"[A-Z]";
            string nameRegex = @"[a-z]";
            string kmRegex = @"[0-9]";
            List<string> people = Console.ReadLine().Split(", ").ToList();
            Dictionary<string, int> racers = new Dictionary<string, int>();
            foreach (var item in people)
            {
                racers.Add(item, 0);
            }
            string input = string.Empty;
            while((input=Console.ReadLine())!="end of race")
            {
                MatchCollection nameOfRacer = Regex.Matches(input, nameRegex);
                string name = Regex.Match(input,CapnameRegex).ToString();
                foreach (var item in nameOfRacer)
                {
                    name += item;
                }
                MatchCollection kmOfRacer = Regex.Matches(input, kmRegex);
                int kms = 0;
                foreach (var item in kmOfRacer)
                {
                    kms +=int.Parse(item.ToString());
                }
                if (racers.ContainsKey(name))
                {
                    racers[name] += kms;
                }
            }
            int i = 0;
            foreach (var item in racers.OrderByDescending(x=>x.Value))
            {
                if (i == 0)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                    i++;
                }
                else if (i == 1)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                    i++;
                }
                else
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                    break;
                }
            }
        }
    }
}
