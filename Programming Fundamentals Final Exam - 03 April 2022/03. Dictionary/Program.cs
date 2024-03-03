using System;
using System.Collections.Generic;

namespace _03._Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsAndDefs = Console.ReadLine().Split(" | ");
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
            for (int i = 0; i < wordsAndDefs.Length; i++)
            {
                string[] wordAndDef = wordsAndDefs[i].Split(": ");
                string word = wordAndDef[0];
                string def = wordAndDef[1];
                if (words.ContainsKey(word))
                {
                    words[word].Add(def);
                }
                else
                {
                    List<string> currentList = new List<string> { def};
                    words.Add(word, currentList);
                }
            }
            string[] testingWord = Console.ReadLine().Split(" | ");
            string command = Console.ReadLine();
            if (command == "Test")
            {
                foreach (var item in testingWord)
                {
                    if (words.ContainsKey(item))
                    {
                        Console.WriteLine($"{item}:");
                        foreach (var itemWithin in words[item])
                        {
                            Console.WriteLine($"-{itemWithin}");
                        }
                    }
                }
            }
            else
            {
                foreach (var item in words)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
