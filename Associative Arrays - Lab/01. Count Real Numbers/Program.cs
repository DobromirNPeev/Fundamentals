using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            SortedDictionary<double, int> occurence = new SortedDictionary<double, int>();
            foreach (var item in numbers)
            {
                if (occurence.ContainsKey(item))
                {
                    occurence[item]++;
                }
                else
                {
                    occurence.Add(item, 1);
                }
            }
            foreach (var item in occurence)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
