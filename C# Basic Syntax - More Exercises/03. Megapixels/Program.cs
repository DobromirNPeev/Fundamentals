using System;

namespace _03._Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var width =long.Parse(Console.ReadLine());
            var height = long.Parse(Console.ReadLine());
            double sum = width * height;
            double megapixels = sum / 1000000;
            Console.WriteLine($"{width}x{height} => {Math.Round(megapixels,1)}MP");
        }
    }
}
