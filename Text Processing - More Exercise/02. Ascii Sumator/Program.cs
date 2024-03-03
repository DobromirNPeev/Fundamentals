using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char begin = char.Parse(Console.ReadLine());
            char final = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;
            foreach (var curr in input)
            {
                if(curr>begin && curr < final)
                {
                    sum += curr;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
