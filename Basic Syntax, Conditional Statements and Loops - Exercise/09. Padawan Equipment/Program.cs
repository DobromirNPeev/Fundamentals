using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var lightsaberPrice = double.Parse(Console.ReadLine());
            var robePrice = double.Parse(Console.ReadLine());
            var beltPrice = double.Parse(Console.ReadLine());
            double sum = 0;
            int countFreeBelt = 0;
            int countBelt = students;
            for (int i = 1; i <= students; i++)
            {
                if (i % 6 == 0)
                {
                    countFreeBelt++;
                }
            }
            countBelt-=countFreeBelt;
            double lightsaberCount = Math.Ceiling(students * 1.1);
            sum = (lightsaberPrice * lightsaberCount) + (students * robePrice) + (beltPrice * countBelt);
            if (sum > budget)
            {
                Console.WriteLine($"John will need {sum-budget:f2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
        }
    }
}
