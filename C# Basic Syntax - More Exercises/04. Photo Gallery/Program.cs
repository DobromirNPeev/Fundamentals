using System;

namespace _04._Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            double sizeInBytes= int.Parse(Console.ReadLine());
            int width= int.Parse(Console.ReadLine());
            int height= int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: DSC_{num:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hour:d2}:{minute:d2}");
            if (sizeInBytes < 1024)
            {
                Console.WriteLine($"Size: {sizeInBytes}B");
            }
            else if(sizeInBytes>=1024 && sizeInBytes < 1048576)
            {
                Console.WriteLine($"Size: {Math.Round(sizeInBytes/1000,1)}KB");
            }
            else
            {
                Console.WriteLine($"Size: {Math.Round(sizeInBytes/1000000,1)}MB");
            }
            if (width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            else if (height > width)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
            else
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
        }
    }
}
