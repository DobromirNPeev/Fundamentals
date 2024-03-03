using System;
using System.Linq;

namespace _01._Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] leavingTime = Console.ReadLine().Split(":").Select(int.Parse).ToArray();
            int steps = int.Parse(Console.ReadLine());
            int timeForAStep = int.Parse(Console.ReadLine());
            int secondsForSteps = steps * timeForAStep;
            for (int i = 0; i < secondsForSteps; i++)
            {
                leavingTime[2]++;
                if (leavingTime[2] == 60)
                {
                    leavingTime[2] = 0;
                    leavingTime[1]++;
                    if (leavingTime[1] == 60)
                    {
                        leavingTime[1] = 0;
                        leavingTime[0]++;
                        if (leavingTime[0]==24)
                        {
                            leavingTime[0] = 0;
                            leavingTime[1] = 0;
                            leavingTime[2] = 0;
                        }
                    }
                }
            }
            Console.WriteLine($"Time Arrival: {leavingTime[0]:d2}:{leavingTime[1]:d2}:{leavingTime[2]:d2}");
        }
    }
}
