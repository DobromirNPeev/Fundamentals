using System;

namespace _11._Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float timeInSeconds = hours * 3600 + minutes * 60 + seconds;
            float timeInHours = hours + minutes * 0.0166667f + seconds* 0.00027777833333f;
            float metresAndSeconds = distanceInMeters / timeInSeconds;
            float kilometresAndHours = (float)(distanceInMeters/1000) / timeInHours;
            float milesAndHours = distanceInMeters/1609f / timeInHours;
            Console.WriteLine(metresAndSeconds);
            Console.WriteLine(kilometresAndHours);
            Console.WriteLine(milesAndHours);

        }
    }
}
