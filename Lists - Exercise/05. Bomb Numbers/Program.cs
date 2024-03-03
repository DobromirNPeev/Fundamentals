using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bombNumber = bombAndPower[0];
            int bombPower = bombAndPower[1];
            int sum = 0;
            List<int> removed = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int currentCount = numbers.Count;
                    int iBombPower = i - bombPower;
                    if (iBombPower < 0)
                    {
                        iBombPower = 0;
                    }
                    for (int j =0; j <bombPower; j++)
                    {
                        if (iBombPower < 0 || iBombPower >= currentCount) break;
                        removed.Add(numbers[iBombPower]);
                        iBombPower++;
                    }
                    if (iBombPower < 0)
                    {
                        iBombPower = 0;
                    }
                    for (int j = -1; j < bombPower; j++)
                    {
                        if (iBombPower < 0 || iBombPower >= currentCount) break;
                        removed.Add(numbers[iBombPower]);
                        iBombPower++;
                    }
                    int originalCount = numbers.Count;
                    for (int index = 0; index < originalCount; index++)
                    {
                        while (numbers[index]==removed[0])
                        {
                            numbers.RemoveAt(index);
                            removed.RemoveAt(0);
                            if (removed.Count == 0) break;
                        }
                        if (removed.Count == 0) break;
                    }
                    i = 0;
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
