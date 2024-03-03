using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            foreach (var item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[item.Length-1];
                string currItem = item;
                currItem = currItem.Remove(0, 1);
                currItem = currItem.Remove(currItem.Length-1, 1);
                double currSum = double.Parse(currItem);
                if(firstLetter>=65 && firstLetter <= 90)
                {
                    int position = firstLetter - 64;
                    currSum /= position;
                }
                else if(firstLetter>=97 && firstLetter <= 122)
                {
                    int position = firstLetter - 96;
                    currSum *= position;
                }
                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    int position = lastLetter - 64;
                    currSum -= position;
                }
                else if (lastLetter >= 97 && lastLetter <= 122)
                {
                    int position = lastLetter - 96;
                    currSum += position;
                }
                sum += currSum;
            }
            sum = Math.Round(sum,2);
            Console.WriteLine($"{sum:f2}");
        }
    }
}
