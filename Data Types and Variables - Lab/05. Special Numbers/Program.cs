using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isSpecial = false;
            int sum = 0;
            for (int i = 1; i <=n; i++)
            {
                int currentNumber = i;
                sum = 0;

                while (currentNumber != 0)
                {
                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }

                isSpecial = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
