using System;

namespace _04._Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = Console.ReadLine();
            int number = Convert.ToInt32(answer, 16);
            Console.WriteLine(number);
        }
    }
}
