using System;

namespace _05._BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double BPM = int.Parse(Console.ReadLine());
            double beats = int.Parse(Console.ReadLine());
            double bars = (double)beats / 4;
            double time=60/BPM;
            time = time * beats;
            int hour = 0;
            int seconds = 0;
            if (BPM == beats)
            {
                time = 1;
                Console.WriteLine($"{Math.Round(bars,1)} bars - {time}m 0s");
            }
            else if(BPM > beats)
            {
                Console.WriteLine($"{Math.Round(bars, 1)} bars - 0m {Math.Floor(time)}s");
            }
            else
            {
                seconds = (int)time % 60;
                hour = (int)time / 60;
                Console.WriteLine($"{Math.Round(bars, 1)} bars - {hour}m {seconds}s");
            }
        }
    }
}
