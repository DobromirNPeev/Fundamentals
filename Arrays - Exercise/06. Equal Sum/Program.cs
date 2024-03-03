using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool thereIs = false;
            int index = 0;
            if (arr.Length == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int leftSum = 0;
                    int rightSum = 0;
                    int leftCount = 0;
                    int rightCount = i+1;
                    while (leftCount < i)
                    {
                        leftSum += arr[leftCount];
                        leftCount++;
                    }
                    while(i<rightCount && rightCount <= arr.Length - 1)
                    {
                        rightSum += arr[rightCount];
                        rightCount++;
                    }
                    if (leftSum == rightSum)
                    {
                        thereIs = true;
                        index = i;
                    }
                }
                if (thereIs)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
