using System;

namespace _06._DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchSum = int.Parse(Console.ReadLine());
            int count = 0;
            int sum = 0;
            int A1 = 1;
            int A2 = 1;
            int A3 = 1;
            int A4 = 1;
            for (char i = 'A'; i <= 'T'; i++)
            {
                if (i == 'A' || i == 'C' || i == 'T' || i == 'G')
                {
                    for (char j = 'A'; j <= 'T'; j++)
                    {
                        if (j == 'A' || j == 'C' || j == 'T' || j == 'G')
                        {
                            for (char k = 'A'; k <= 'T'; k++)
                            {
                                if (k == 'A' || k == 'C' || k == 'T' || k == 'G')
                                {
                                    if (count == 4)
                                    {
                                        Console.WriteLine();
                                        count = 0;
                                    }
                                    sum = A1 + A2 + A3;
                                    if (sum >= matchSum)
                                    {
                                        Console.Write($"O{i}{j}{k}O ");
                                        count++;
                                    }
                                    else
                                    {
                                        Console.Write($"X{i}{j}{k}X ");
                                        count++;
                                    }
                                    A3++;
                                }
                            }
                            A3 = 1;
                            A2++;
                        }
                    }
                    A2 = 1;
                    A1++;
                }
            }
        }
    }
}
