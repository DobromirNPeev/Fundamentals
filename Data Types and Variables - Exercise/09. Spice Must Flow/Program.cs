using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;
            while (startingYield>=100)
            {
                int yield = startingYield - 26;
                sum += yield;
                startingYield -= 10;
                if(startingYield < 100 && startingYield>26)
                {
                    sum -= 26;
                }
                count++;
            }
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }
}
