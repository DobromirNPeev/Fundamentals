using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commands[0] == "merge")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    input = Merge(input, startIndex, endIndex);
                }
                else
                {
                    int index = int.Parse(commands[1]);
                    int partitions = int.Parse(commands[2]);
                    input = Divide(input, index, partitions);
                }
            }
            List<string> removeEmptiesEnd = new List<string>(input);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == string.Empty)
                {
                    removeEmptiesEnd.Remove(input[i]);
                }
            }
            input = removeEmptiesEnd.ToArray();
            Console.WriteLine(string.Join(" ", input));
        }
        static string[] Merge(string[] input, int StartIndex, int EndIndex)
        {
            List<string> inputAsList = input.ToList();
            StringBuilder concat = new StringBuilder();
            if (StartIndex < 0) StartIndex = 0;
            if (EndIndex > input.Length - 1) EndIndex = input.Length - 1;
            for (int i = StartIndex; i <= EndIndex; i++)
            {
                if (i >= 0 && i < input.Length)
                {
                    concat.Append(input[i]);
                    input[i] = string.Empty;
                }
            }
            for (int i = StartIndex; i <= EndIndex; i++)
            {
                if (i >= 0 && i < input.Length)
                {
                    inputAsList.RemoveAt(StartIndex);
                }
            }
            if (EndIndex < input.Length && EndIndex >= 0)
            {
                input[EndIndex] = concat.ToString();
            }
            else if (EndIndex >= input.Length && StartIndex < input.Length)
            {
                input[StartIndex] = concat.ToString();
            }
            List<string> removeEmptiesEnd = new List<string>(input);
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == string.Empty)
                {
                    removeEmptiesEnd.Remove(input[i]);
                }
            }
            input = removeEmptiesEnd.ToArray();
            return input;
        }
        static string[] Divide(string[] input, int index, int partitions)
        {
            List<string> inputAsList = input.ToList();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == string.Empty)
                {
                    inputAsList.Remove(input[i]);
                }
            }
            string indexAsString = input[index];
            double newstringLength = (double)indexAsString.Length / partitions;
            string currentStr = string.Empty;
            List<string> newestList = new List<string>();
            int count = 0;
            int DividedCount = 0;
            if (newstringLength % 2 == 0)
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
                            while (i < indexAsString.Length - 1)
                            {
                                currentStr += indexAsString[i + 1];
                                i++;
                            }
                        }
                        newestList.Add(currentStr);
                        count = 0;
                        currentStr = string.Empty;
                    }
                }
            }
            inputAsList.RemoveAt(index);
            newestList.Reverse();
            int newestListOriginalCount = newestList.Count;
            for (int i = 0; i < newestListOriginalCount; i++)
            {
                inputAsList.Insert(index, newestList[0]);
                newestList.RemoveAt(0);
            }
            input = inputAsList.ToArray();
            return input;
        }
    }
}
