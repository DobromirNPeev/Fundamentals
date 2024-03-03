using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int left = 0;
            int[] leftArrayFirst = new int[(sequence.Length / 2)/2];
            int[] leftArraySecond = new int[(sequence.Length / 2)/2];
            int[] leftArray = new int[sequence.Length / 2];
            int j = 0;
            int end = 0;
            int[] rightArray = new int[sequence.Length / 2];
            for (int i = 0; i < leftArray.Length; i++)
            {
                if (i< (sequence.Length / 2)/2)
                {
                    left = sequence[i];
                    leftArrayFirst[i] = left;
                }
                else if(i>= (sequence.Length / 2) / 2)
                {
                    left = sequence[i + (sequence.Length / 2)];
                    leftArraySecond[j] = left;
                    j++;
                    end = j;
                }
            }
            Array.Reverse(leftArrayFirst);
            Array.Reverse(leftArraySecond);
            j = 0;
            for (int i = 0; i < leftArray.Length; i++)
            {
                if (i < leftArrayFirst.Length)
                {
                    leftArray[i] = leftArrayFirst[i];
                }
                else
                {
                    leftArray[i] = leftArraySecond[j];
                    j++;
                }
            }
            j = 0;
            for (int i = (sequence.Length / 2) / 2;i< (sequence.Length / 2) +end; i++)
            {
                rightArray[j] = sequence[i];
                j++;
            }
            int sum = 0;
            for (int i = 0; i < sequence.Length/2; i++)
            {
                sum = leftArray[i] + rightArray[i];
                Console.Write($"{sum} ");
            }
        }
    }
}
