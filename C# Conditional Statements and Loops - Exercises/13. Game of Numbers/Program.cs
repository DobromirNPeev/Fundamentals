using System;

namespace _13._Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicalNum = int.Parse(Console.ReadLine());
            int count = 0;
            int first = 0;
            int second = 0;
            bool isThereMagicNum = false;
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if (i + j==magicalNum)
                    {
                        isThereMagicNum = true;
                        first = i;
                        second = j;
                        count++;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            if (isThereMagicNum)
            {
                Console.WriteLine($"Number found! {first} + {second} = {magicalNum}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicalNum}");
            }
        }
    }
}
