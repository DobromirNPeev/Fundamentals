using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double max = double.MinValue;
            string biggest = string.Empty;
            for (int i = 1; i <=n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;
                if (volume > max)
                {
                    max = volume; ;
                    biggest = model;
                }
            }
            Console.WriteLine(biggest); ;
        }
    }
}
