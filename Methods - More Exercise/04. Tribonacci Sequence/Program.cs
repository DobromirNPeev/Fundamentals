using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            TribonacciSequence(num);
        }
        static void TribonacciSequence(int num)
        {
            int[] arr = new int[num];
            if (num == 1)
            {
                arr[0] = 1;
                Console.WriteLine(string.Join(" ", arr));
                return;
            }
            else if (num == 2)
            {
                arr[0] = 1;
                arr[1] = 1;
                Console.WriteLine(string.Join(" ", arr));
                return;
            }
            else if (num == 3)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }
            else
            {
                arr[0] = 1;
                arr[1] = 1;
                arr[2] = 2;
                int[] sum = new int[3];
                int count = 0;
                sum[0] = 1;
                sum[1] = 1;
                sum[2] = 2;
                for (int i = 3; i < num; i++)
                {
                    arr[i] = sum[0] + sum[1] + sum[2];
                    sum[count] = arr[i];
                    count++;
                    if (count == 3)
                    {
                        count = 0;
                    }
                }
                Console.WriteLine(string.Join(" ", arr));
            }
        }
    }
}
