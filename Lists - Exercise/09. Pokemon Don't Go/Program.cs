using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> removed = new List<int>();
            while (input.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    removed.Add(input[0]);
                    int removedIndex = input[0];
                    input[0] = input[input.Count - 1];
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] <= removedIndex)
                        {
                            input[i] += removedIndex;
                        }
                        else
                        {
                            input[i] -= removedIndex;
                        }
                    }
                }
                else if (index > input.Count-1)
                {
                    removed.Add(input[input.Count-1]);
                    int removedIndex = input[input.Count-1];
                    input[input.Count - 1] = input[0];
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] <= removedIndex)
                        {
                            input[i] += removedIndex;
                        }
                        else
                        {
                            input[i] -= removedIndex;
                        }
                    }
                }
                else
                {
                    removed.Add(input[index]);
                    int removedInteger = input[index];
                    input.RemoveAt(index);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] <= removedInteger)
                        {
                            input[i] += removedInteger;
                        }
                        else
                        {
                            input[i] -= removedInteger;
                        }
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < removed.Count; i++)
            {
                sum += removed[i];
            }
            Console.WriteLine(sum);
        }
    }
}
