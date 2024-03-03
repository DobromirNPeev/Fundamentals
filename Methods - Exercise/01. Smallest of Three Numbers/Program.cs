using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMin(first,second,third));
        }
        static int GetMin(int first,int second, int third)
        {
            int min = int.MaxValue;
            if(first <= second && first <= third)
            {
                min = first;
            }
            if(second <= first && second <= third)
            {
                min = second;
            }
            if(third <= second && third <= first)
            {
                min = third;
            }
            return min;
        }
    }
}
