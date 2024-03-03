using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "course start")
            {
                string[] commands = command.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string firstCommand = commands[0];
                if (firstCommand == "Add")
                {
                    string lesson = commands[1];
                    input = Adding(input, lesson);
                }
                else if (firstCommand == "Insert")
                {
                    string lesson = commands[1];
                    int index = int.Parse(commands[2]);
                    input = Inserting(input, lesson, index);
                }
                else if (firstCommand == "Remove")
                {
                    string lesson = commands[1];
                    input = Removing(input, lesson);
                }
                else if (firstCommand == "Swap")
                {
                    string firstLesson = commands[1];
                    string secondLesson = commands[2];
                    input = Swaping(input, firstLesson, secondLesson);
                }
                else if (firstCommand == "Exercise")
                {
                    string lesson = commands[1];
                    input = Exercise(input, lesson);
                }
            }
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{input[i]}");
            }
        }
        static List<string> Adding(List<string> input, string lesson)
        {
            if (!input.Contains(lesson))
            {
                input.Add(lesson);
            }
            return input;
        }
        static List<string> Inserting(List<string> input, string lesson, int index)
        {
            if (!input.Contains(lesson) && index >= 0 && index < input.Count)
            {
                input.Insert(index, lesson);
            }
            return input;
        }
        static List<string> Removing(List<string> input, string lesson)
        {
            if (input.Contains(lesson))
            {
                input.Remove(lesson);
                if (input.Contains($"{lesson}-Exercise"))
                {
                    input.Remove($"{lesson}-Exercise");
                }
            }
            return input;
        }
        static List<string> Swaping(List<string> input, string lesson1, string lesson2)
        {
            bool exist1 = false;
            bool exist2 = false;
            for (int i = 0; i < input.Count; i++)
            {
                if (input.Contains(lesson1))
                {
                    exist1 = true;
                }
            }
            for (int i = 0; i < input.Count; i++)
            {
                if (input.Contains(lesson2))
                {
                    exist2 = true;
                }
            }
            if (exist1 && exist2)
            {
                string lesson1Save = lesson1;
                string lesson2Save = lesson2;

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] == lesson1)
                    {
                        input[i] = lesson2Save;
                        if (input.Contains($"{lesson2Save}-Exercise"))
                        {
                            input.Remove($"{lesson2Save}-Exercise");
                            input.Insert(i + 1, $"{lesson2Save}-Exercise");
                        }
                    }
                    else if (input[i] == lesson2)
                    {
                        input[i] = lesson1Save;
                        if (input.Contains($"{lesson1Save}-Exercise"))
                        {
                            input.Remove($"{lesson1Save}-Exercise");
                            input.Insert(i, $"{lesson1Save}-Exercise");
                        }
                    }
                }
            }
            return input;
        }
        static List<string> Exercise(List<string> input, string lesson)
        {
            if (input.Contains(lesson) && !input.Contains(lesson + "-Exercise"))
            {
                int index = input.IndexOf(lesson);
                string exercise = $"{lesson}-Exercise";
                input.Insert(index + 1, exercise);
            }
            else if (!input.Contains(lesson))
            {
                input.Add(lesson);
                string exercise = $"{lesson}-Exercise";
                input.Add(exercise);
            }
            return input;
        }
    }
}
