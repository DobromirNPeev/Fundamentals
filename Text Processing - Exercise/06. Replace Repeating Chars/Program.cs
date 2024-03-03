using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                int counter = 0;
                int indexOg = i;
                while(input[indexOg] == input[i])
                {
                    counter++;
                    i++;
                    if (i >= input.Length) break;
                }
                input = input.Remove(indexOg, counter-1);
                i = indexOg;
            }
            Console.WriteLine(input);
        }
    }
}
