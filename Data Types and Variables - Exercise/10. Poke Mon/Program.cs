using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int originaN = n;
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int count =0;
            while (n >= m)
            {
                n -= m;
                count++;
                if (n == originaN / 2)
                {
                    if (y != 0)
                    {
                        n = n / y;
                    }
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
