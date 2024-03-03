using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstLine = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            List<int> secondLine = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToList();
            List<int> resultList = new List<int>();
            int j = secondLine.Count - 1;
            List<int> leftBehind = new List<int>();
            if (firstLine.Count > secondLine.Count)
            {
                for (int i = 0; i < firstLine.Count; i++)
                {
                    if (j < 0)
                    {
                        break;
                    }
                    resultList.Add(firstLine[i]);
                    if (j >= 0)
                    {
                        resultList.Add(secondLine[j]);
                    }
                    j--;
                }
                for (int left = secondLine.Count; left < firstLine.Count; left++)
                {
                    leftBehind.Add(firstLine[left]);
                }
            }
            else
            {
                for (int i = 0; i < secondLine.Count; i++)
                {
                    if (i == firstLine.Count)
                    {
                        break;
                    }
                    resultList.Add(firstLine[i]);
                    if (j >= 0)
                    {
                        resultList.Add(secondLine[j]);
                    }
                    j--;
                }
                for (int left = 0; left < secondLine.Count-firstLine.Count; left++)
                {
                    leftBehind.Add(secondLine[left]);
                }
            }
            leftBehind.Sort();
            List<int> finalList = new List<int>();
            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i]>leftBehind[0] && resultList[i]<leftBehind[1])
                {
                    finalList.Add(resultList[i]);
                }
            }
            finalList.Sort();
            Console.WriteLine(string.Join(" ",finalList));
        }
    }
}
