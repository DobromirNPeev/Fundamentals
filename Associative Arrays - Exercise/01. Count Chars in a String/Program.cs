using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ').ToArray();
            Dictionary<char, int> counts = new Dictionary<char, int>();
            for (int i = 0; i < inputs.Length; i++)
            {
                foreach (char item in inputs[i])
                {
                    if (counts.ContainsKey(item))
                    {
                        counts[item]++;
                    }
                    else
                    {
                        counts.Add(item, 1);
                    }
                }
            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
