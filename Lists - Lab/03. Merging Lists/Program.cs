using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result=new List<int>();
            List<int> diff=new List<int>();
            int length = 0;
            if (first.Count > second.Count)
            {
                length=second.Count;
                for (int i =second.Count; i < first.Count; i++)
                {
                    diff.Add(first[i]);
                }
            }
            else
            {
                length = first.Count;
                for (int i = first.Count; i < second.Count; i++)
                {
                    diff.Add(second[i]);
                }
            }
            for (int i = 0; i < length; i++)
            {
                result.Add(first[i]);
                result.Add(second[i]);
            }
            result.AddRange(diff);
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
