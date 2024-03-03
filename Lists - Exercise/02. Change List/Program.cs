using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputs = input.Split();
                if (inputs[0] == "Delete")
                {
                    int number = int.Parse(inputs[1]);
                    Delete(numbers,number);
                }
                else
                {
                    int element = int.Parse(inputs[1]);
                    int position = int.Parse(inputs[2]);
                    Insert(numbers, element, position);
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
        static List<int> Delete(List<int> numbers,int number)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i]==number)
                {
                    numbers.RemoveAll(x => x == number);
                }
            }
            return numbers;
        }
        static List<int> Insert(List<int> numbers, int element,int position)
        {
            numbers.Insert(position, element);
            return numbers;
        }
    }
}
