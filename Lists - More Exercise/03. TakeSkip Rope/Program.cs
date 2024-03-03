using System;
using System.Collections.Generic;

namespace _03._TakeSkip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbersList = new List<int>();
            List<string> nonnumbersList = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (int.TryParse(input[i].ToString(), out int result))
                {
                    numbersList.Add(result);
                }
                else
                {
                    nonnumbersList.Add(input[i].ToString());
                }
            }
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0) 
                {
                    takeList.Add(int.Parse(numbersList[i].ToString()));
                }
                else
                {
                    skipList.Add(int.Parse(numbersList[i].ToString()));
                }
            }
            List<string> resultList = new List<string>();
            int skippedCount = 0;
            int takenCount = 0;
            int originatLength = nonnumbersList.Count;
            for (int i = skipList[skippedCount]; i <= originatLength; i+=skipList[skippedCount])
            {
                int count = 0;
                string current = string.Empty;
                while (count < takeList[takenCount] && nonnumbersList.Count!=0)
                {
                    current += nonnumbersList[0];
                    i++;
                    count++;
                    nonnumbersList.RemoveAt(0);
                }
                count = 0;
                while (count < skipList[skippedCount] && nonnumbersList.Count != 0)
                {
                    nonnumbersList.RemoveAt(0);
                    count++;
                }
                resultList.Add(current);
                skippedCount++;
                if (skippedCount > skipList.Count - 1) break;
                takenCount++;
                if (takenCount > takeList.Count - 1) break;
            }
            Console.WriteLine(string.Join("",resultList));
        }
    }
}
