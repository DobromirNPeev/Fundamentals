using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginning = int.Parse(Console.ReadLine());
            int ending = int.Parse(Console.ReadLine());
            for (int i =beginning; i <= ending; i++)
            {
                char symbol =(char) i;
                Console.Write(symbol+" ");
            }
        }
    }
}
