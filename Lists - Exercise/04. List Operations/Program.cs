using System;
using System.Collections.Generic;
using System.Linq;


namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputs = input.Split();
                string command = inputs[0];
                if (command == "Add")
                {
                    int number = int.Parse(inputs[1]);
                    add(numbers, number);
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(inputs[1]);
                    if (index < 0 || index > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        remove(numbers, index);
                    }
                }
                else if (command == "Shift")
                {
                    string position = inputs[1];
                    if (position == "left")
                    {
                        int count = int.Parse(inputs[2]);
                        ShiftLeft(numbers, count);
                    }
                    else
                    {
                        int count = int.Parse(inputs[2]);
                        ShiftRight(numbers, count);
                    }
                }
                else
                {
                    int element = int.Parse(inputs[1]);
                    int position = int.Parse(inputs[2]);
                    if (position < 0 || position > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        Insert(numbers, element, position);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
        static List<int> add(List<int> numbers, int number)
        {
            numbers.Add(number);
            return numbers;
        }
        static List<int> Insert(List<int> numbers, int element, int position)
        {
            numbers.Insert(position, element);
            return numbers;
        }
        static List<int> remove(List<int> numbers, int index)
        {
            numbers.RemoveAt(index);
            return numbers;
        }
        static List<int> ShiftLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                numbers.Add(numbers[0]);
                numbers.RemoveAt(0);
            }
            return numbers;
        }
        static List<int> ShiftRight(List<int> numbers, int count)
        {
            for (int i = 0; i <count; i++)
            {
                numbers.Insert(0,numbers[numbers.Count-1]);
                numbers.RemoveAt(numbers.Count-1);
            }
            return numbers;
        }
    }
}
