using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> valuable = new SortedDictionary<string, int>();
            valuable["shards"] = 0;
            valuable["fragments"] = 0;
            valuable["motes"] = 0;
            Dictionary<string, int> junk = new Dictionary<string, int>();
            string weapon = string.Empty;
            while (true)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                List<string> now = new List<string>();
                bool isFound = false;
                for (int i = 0; i < input.Count; i++)
                {
                    now.Add(input[i]);
                    if (now.Count == 2)
                    {
                        string lowered = now[1].ToLower();
                        int value = int.Parse(now[0]);
                        if (lowered == "shards" || lowered == "fragments" || lowered == "motes")
                        {
                            if (valuable.ContainsKey(lowered))
                            {
                                valuable[lowered] += value;
                                if (valuable[lowered] >= 250)
                                {
                                    isFound = true;
                                    valuable[lowered] -= 250;
                                    if (lowered == "fragments")
                                    {
                                        weapon = "Valanyr";
                                    }
                                    else if (lowered == "shards")
                                    {
                                        weapon = "Shadowmourne";
                                    }
                                    else
                                    {
                                        weapon = "Dragonwrath";
                                    }
                                    break;
                                }                                
                            }
                        }
                        else
                        {
                            if (junk.ContainsKey(lowered))
                            {
                                junk[lowered] += value;
                            }
                            else
                            {
                                junk.Add(lowered, value);
                            }
                        }
                        now = new List<string>();
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            Console.WriteLine($"{weapon} obtained!");
            foreach (var item in valuable)
            {
                if (item.Key == "shards")
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            foreach (var item in valuable)
            {
                if (item.Key == "motes")
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            foreach (var item in valuable)
            {
                if (item.Key == "fragments")
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
