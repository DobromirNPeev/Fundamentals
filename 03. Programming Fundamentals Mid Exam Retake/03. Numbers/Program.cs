using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            double average = (double)input.Sum()/input.Count;
            List<int> validList = new List<int>();
            int maxCount = 0;
            int maxIndex = 0;
            int max = int.MinValue;
            bool changed = false;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] > average)
                {
                    validList.Add(input[i]);
                    changed = true;
                }
            }
            List<int> finalList = new List<int>();
            if (changed)
            {
                if (validList.Count < 5)
                {
                    validList.Sort();
                    validList.Reverse();
                    Console.WriteLine(string.Join(" ",validList));
                }
                else
                {
                    while (maxCount < 5)
                    {
                        for (int i = 0; i < validList.Count; i++)
                        {
                            if (validList[i] >= max)
                            {
                                max = validList[i];
                                maxIndex = i;
                            }
                        }
                        validList.RemoveAt(maxIndex);
                        finalList.Add(max);
                        max = int.MinValue;
                        maxCount++;
                    }
                    Console.WriteLine(string.Join(" ", finalList));
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
