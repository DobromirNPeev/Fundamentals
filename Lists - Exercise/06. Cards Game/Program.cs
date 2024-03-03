using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            int firstSum = 0;
            int secondSum = 0;
            int longest = Math.Max(firstHand.Count, secondHand.Count);
            while(firstHand.Count!=0 && secondHand.Count!=0)
            {
                if (firstHand[0] > secondHand[0])
                {
                    firstHand.Add(secondHand[0]);
                    firstHand.Add(firstHand[0]);
                    firstHand.Remove(firstHand[0]);
                    secondHand.Remove(secondHand[0]);
                }
                else if(firstHand[0] < secondHand[0])
                {
                    secondHand.Add(firstHand[0]);
                    secondHand.Add(secondHand[0]);
                    secondHand.Remove(secondHand[0]);
                    firstHand.Remove(firstHand[0]);

                }
                else
                {
                    firstHand.Remove(firstHand[0]);
                    secondHand.Remove(secondHand[0]);
                }
            }
            for (int i = 0; i < firstHand.Count; i++)
            {
                firstSum += firstHand[i];
            }
            for (int i = 0; i < secondHand.Count; i++)
            {
                secondSum += secondHand[i];
            }
            if (firstSum > secondSum)
            {
                Console.WriteLine($"First player wins! Sum: {firstSum}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondSum}");
            }
        }
    }
}
