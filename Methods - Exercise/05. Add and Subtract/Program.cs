using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sum = AddOf1And2(first, second);
            Console.WriteLine(SubtractSumFrom3(sum,third));
        }
        static int AddOf1And2(int first,int second)
        {
            return first + second;
        }
        static int SubtractSumFrom3(int sum,int third)
        {
           return sum - third;
        }
    }
}
