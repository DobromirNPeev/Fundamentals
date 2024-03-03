using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> numbers= new List<string>();
            for (int i = 0; i <array.Length; i++)
            {
                numbers.Add(array[i]);
            }
            List<int> numbersInt = new List<int>();
            for (int i = numbers.Count-1; i >= 0; i--)
            {
                List<string> work = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int j = 0; j < work.Count; j++)
                {
                        numbersInt.Add(int.Parse(work[j]));
                }
            }
            Console.WriteLine(string.Join(" ",numbersInt));
        }
    }
}
