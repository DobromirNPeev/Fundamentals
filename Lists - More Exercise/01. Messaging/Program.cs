using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            string input = Console.ReadLine();
            List<string> strings = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                strings.Add(input[i].ToString());
            }
            List<string> removed = new List<string>();
            int sumIndex = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                string currentNum = numbers[i].ToString();
                sumIndex = 0;
                for (int j = 0; j < currentNum.Length; j++)
                {
                    sumIndex +=int.Parse(currentNum[j].ToString());
                }
                if (sumIndex > strings.Count)
                {
                    for (int count = 0; count <strings.Count; count++)
                    {
                        if (count == strings.Count-1)
                        {
                            sumIndex -= count+1;
                        }
                    }
                    removed.Add(strings[sumIndex]);
                    strings.RemoveAt(sumIndex);
                }
                else
                {
                    removed.Add(strings[sumIndex]);
                    strings.RemoveAt(sumIndex);
                }
            }
            Console.WriteLine(string.Join("",removed));
        }
    }
}
