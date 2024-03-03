using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int employeeSsum = firstEmployee + secondEmployee + thirdEmployee;
            int neededTime = 0;
            while(studentsCount>0)
            {
                neededTime++;
                if (neededTime %4 ==0)
                {
                    continue;
                }
                studentsCount -= employeeSsum;
            }
            Console.WriteLine($"Time needed: {neededTime}h.");
        }
    }
}
