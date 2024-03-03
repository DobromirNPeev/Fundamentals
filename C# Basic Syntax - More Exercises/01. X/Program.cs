using System;

namespace _01._X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int end = n-1;
            int z = 2;
            for (int i = 0; i < n/2+1; i++)
            {
                if(i==0)
                {
                    Console.Write("x");
                    for (int j = 2; j <= n - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("x");
                    Console.WriteLine();
                }
                else
                {
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("x");
                    for (int middle = z; middle < end-1; middle++)
                    {
                        Console.Write(" ");
                    }
                    z++;
                    end--;
                    if (i != n / 2 )
                    {
                        Console.Write("x");
                    }
                    for (int k = i; k >= 1; k--)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            int back = n / 2;
            int front = n / 2+1;
            for (int i = n / 2-1 ; i >=0; i--)
            {
                if (i == n)
                {
                    Console.Write("x");
                    for (int j = 2; j <= n - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("x");
                    Console.WriteLine();
                }
                else
                {
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("x");
                    for (int middle = back; middle < front; middle++)
                    {
                        Console.Write(" ");
                    }
                    back--;
                    front++;
                    if (i != n / 2)
                    {
                        Console.Write("x");
                    }
                    for (int k = i; k >= 1; k--)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
