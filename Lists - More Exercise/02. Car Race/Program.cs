using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            List<int> leftSide = new List<int>();
            for (int i = 0; i < numbers.Count/2; i++)
            {
                leftSide.Add(numbers[i]);
            }
            List<int> rightSide = new List<int>();
            numbers.Reverse();
            for (int i = 0; i < numbers.Count/2; i++)
            {
                rightSide.Add(numbers[i]);
            }
            float leftSum = 0;
            for (int i = 0; i < leftSide.Count; i++)
            {
                if (leftSide[i] == 0)
                {
                    leftSum = leftSum * 0.8f;
                }
                else
                {
                    leftSum += leftSide[i];
                }
            }
            float rightSum = 0;
            for (int i = 0; i < rightSide.Count; i++)
            {
                if (rightSide[i] == 0)
                {
                    rightSum = rightSum * 0.8f;
                }
                else
                {
                    rightSum += rightSide[i];
                }
            }
            if (leftSum < rightSum)
            {
                Console.WriteLine($"The winner is left with total time: {leftSum}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightSum}");
            }
        }
    }
}
