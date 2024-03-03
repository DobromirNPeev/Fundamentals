using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int longestCount = 0;
            int maxCount = 0;
            int[] longest = new int[0];

            for (int i = 0; i < arr.Length; i++)
            {
                longestCount = 0;
                int continuity = i;
                while (arr[i] == arr[continuity] && continuity < arr.Length - 1)
                {
                    continuity++;
                    longestCount++;
                }
                if (arr[i] == arr[continuity] && continuity == arr.Length - 1)
                {
                    longestCount++;
                }
                if (longestCount > maxCount)
                {
                    maxCount = longestCount;
                    longest = new int[maxCount];
                    for (int j = 0; j < longest.Length; j++)
                    {
                        longest[j] = arr[i];
                    }
                }
            }
            Console.WriteLine(string.Join(" ",longest));
        }
    }
}
