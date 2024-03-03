using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split("|").ToList();
            string input = string.Empty;
            while((input=Console.ReadLine())!= "Yohoho!")
            {
                string[] arr = input.Split();
                if (arr[0] == "Loot")
                {
                    for (int i = 1; i < arr.Length; i++)
                    {
                        if (!items.Contains(arr[i]))
                        {
                            items.Insert(0, arr[i]);
                        }
                    }
                }
                else if (arr[0] == "Drop")
                {
                    int index = int.Parse(arr[1]);
                    if (index<0 || index >= items.Count)
                    {
                        continue;
                    }
                    string stored = items[index];
                    items.RemoveAt(index);
                    items.Add(stored);
                }
                else
                {
                    int count = int.Parse(arr[1]);
                    List<string> removed = new List<string>();
                    while (count != 0 && items.Count!=0)
                    {
                        removed.Add(items[items.Count - 1]);
                        items.RemoveAt(items.Count - 1);
                        count--;
                    }
                    removed.Reverse();
                    Console.WriteLine(string.Join(", ",removed));
                }
            }
            if (items.Count==0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double sum = 0;
                foreach (var item in items)
                {
                    sum += item.Length;
                }
                Console.WriteLine($"Average treasure gain: {sum/items.Count:f2} pirate credits.");
            }
        }
    }
}
