using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles = int.Parse(Console.ReadLine());
            double km = miles / 1000.0;
            Console.WriteLine($"{Math.Round(km,2):f2}");
        }
    }
}