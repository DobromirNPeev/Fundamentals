using System;

namespace _01._String_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenString = Console.ReadLine();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] props = input.Split(" ");
                string command = props[0];
                if (command == "Translate")
                {
                    string character = props[1];
                    string replacement = props[2];
                    givenString = givenString.Replace(character, replacement);
                    Console.WriteLine(givenString);
                }
                else if (command == "Includes")
                {
                    string substring = props[1];
                    if (givenString.Contains(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Start")
                {
                    string substring = props[1];
                    if (givenString.StartsWith(substring))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Lowercase")
                {
                    givenString = givenString.ToLower();
                    Console.WriteLine(givenString);
                }
                else if (command == "FindIndex")
                {
                    string character = props[1];
                    Console.WriteLine(givenString.LastIndexOf(character));
                }
                else if (command=="Remove")
                {
                    int index = int.Parse(props[1]);
                    int count = int.Parse(props[2]);
                    givenString = givenString.Remove(index, count);
                    Console.WriteLine(givenString);
                }
            }
        }
    }
}
