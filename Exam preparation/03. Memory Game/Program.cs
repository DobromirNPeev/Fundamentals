using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = string.Empty;
            int movesCount = 0;
            bool won = false;
            while ((input = Console.ReadLine()) !="end")
            {
                int[] inputInt = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int firstIndex = inputInt[0];
                int secondIndex = inputInt[1];
                if (firstIndex == secondIndex || firstIndex<0 || firstIndex>elements.Count-1 || secondIndex < 0 || secondIndex > elements.Count-1)
                {
                    movesCount++;
                    elements.Insert(elements.Count/2,$"-{movesCount}a");
                    elements.Insert(elements.Count / 2, $"-{movesCount}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }
                if (elements[firstIndex] == elements[secondIndex])
                {
                    string currEl = elements[firstIndex];
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[firstIndex]}!");
                    elements.RemoveAll(x=>x==currEl);
                    movesCount++;
                }
                else
                {
                    Console.WriteLine("Try again!");
                    movesCount++;
                }
                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {movesCount} turns!");
                    won= true;
                    break;
                }
            }
            if (won==false)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ",elements));
            }
        }
    }
}
