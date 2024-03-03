using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = Console.ReadLine().Split().ToList();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (var item in inputs)
            {
                string lowered = item.ToLower();
                if (counts.ContainsKey(lowered))
                {
                    counts[lowered]++;
                }
                else
                {
                    counts.Add(lowered, 1);
                }
            }
            foreach (var item in counts)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key.ToLower()+" ");
                }
            }
        }
    }
}
