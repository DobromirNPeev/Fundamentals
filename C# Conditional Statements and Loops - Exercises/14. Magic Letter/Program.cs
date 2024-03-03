using System;

namespace _14._Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char finish = char.Parse(Console.ReadLine());
            char notIncluded = char.Parse(Console.ReadLine());
            for (char i = start; i <= finish; i++)
            {
                for (char j = start; j <= finish; j++)
                {
                    for (char k = start; k <= finish; k++)
                    {
                        if(i!=notIncluded && j!=notIncluded && k != notIncluded)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
        }
    }
}
