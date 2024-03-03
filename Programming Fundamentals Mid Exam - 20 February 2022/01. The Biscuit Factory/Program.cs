using System;

namespace _01._The_Biscuit_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBiscuitsPerDay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int numberOfBiscuitsCompetition = int.Parse(Console.ReadLine());
            double produced = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    produced += (double)(numberOfBiscuitsPerDay * 0.75) * workers;
                    produced = Math.Floor(produced);
                }
                else
                {
                    produced += numberOfBiscuitsPerDay * workers;
                }
            }
            Console.WriteLine($"You have produced {produced} biscuits for the past month.");
            if (produced > numberOfBiscuitsCompetition)
            {
                double difference = (int)produced - numberOfBiscuitsCompetition;
                double percentage = difference / numberOfBiscuitsCompetition * 100;
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else
            {
                double difference = numberOfBiscuitsCompetition-(int)produced;
                double percentage = difference / numberOfBiscuitsCompetition * 100f;
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }
        }
    }
}
