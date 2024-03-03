using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int mid = 0;
            int min = int.MaxValue;
            if (n > max)
            {
                max = n;
            }
            if (n1 > max)
            {
                max = n1;
            }
            if (n2 > max)
            {
                max = n2;
            }
            if (n < min)
            {
                min = n;
            }
            if (n1 < min)
            {
                min = n1;
            }
            if (n2 < min)
            {
                min = n2;
            }
            for (int i = min; i <= max; i++)
            {
                if (i == n && (n!=max || n!=min))
                {
                    mid = i;
                }
                if (i == n1 && (n1 != max || n1 != min))
                {
                    mid = i;
                }
                if (i == n2 && (n2 != max || n2 != min))
                {
                    mid = i;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(mid);
            Console.WriteLine(min);
        }
    }
}
