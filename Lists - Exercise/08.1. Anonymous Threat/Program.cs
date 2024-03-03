using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._1._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commands[0] == "merge")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    Merge(input, startIndex, endIndex);
                }
                else if(commands[0] == "divide")
                {
                    int index = int.Parse(commands[1]);
                    int partitions = int.Parse(commands[2]);
                    Divide(input, index, partitions);
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
        static List<string> Merge(List<string> input,int StartIndex,int EndIndex)
        {
            string concat = string.Empty;
            int originalLength = input.Count;
            if (StartIndex < 0) StartIndex = 0;
            if (EndIndex > input.Count - 1) EndIndex = input.Count - 1;
            for (int i = StartIndex; i <= EndIndex; i++)
            {

                    concat+=input[StartIndex];
                    input.RemoveAt(StartIndex);
                
            }
            input.Insert(StartIndex, concat);
            return input;
        }
        static List<string> Divide(List<string> input, int index, int partitions)
        {
            if (partitions == 0) return input;
            string indexAsString = input[index];
            double newstringLength = (double)indexAsString.Length / partitions;
            string currentStr = string.Empty;
            List<string> newestList = new List<string>();
            int count = 0;
            int DividedCount = 0;
            input.RemoveAt(index);
            if (newstringLength % 1 == 0)
            {
                for (int i = 0; i < indexAsString.Length; i++)
                {
                    currentStr += indexAsString[i];
                    count++;
                    if (count == newstringLength)
                    {
                        newestList.Add(currentStr);
                        count = 0;
                        currentStr = string.Empty;
                    }
                }
            }
            else
            {
                for (int i = 0; i < indexAsString.Length; i++)
                {
                    currentStr += indexAsString[i];
                    count++;
                    if (count == (int)newstringLength)
                    {
                        DividedCount++;
                        if (DividedCount == partitions)
                        {
                            while (i <= indexAsString.Length-1)
                            {
                                currentStr += indexAsString[i];
                                i++;
                            }
                        }
                        newestList.Add(currentStr);
                        count = 0;
                        currentStr = string.Empty;
                    }
                }
            }
            newestList.Reverse();
            int newestListOriginalCount = newestList.Count;
            for (int i = 0; i < newestListOriginalCount; i++)
            {
                input.Insert(index,newestList[0]);
                newestList.RemoveAt(0);
            }
            return input;
        }
    }
}
