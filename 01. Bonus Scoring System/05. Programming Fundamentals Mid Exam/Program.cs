using System;

namespace _05._Programming_Fundamentals_Mid_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int addBonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            int maxAttendences = 0;
            for (int i = 0; i < students; i++)
            {
                int attendences = int.Parse(Console.ReadLine());
                double currentBonus = ((double)attendences / lectures) * (5 + addBonus);
                if (currentBonus > maxBonus)
                {
                    maxBonus = currentBonus;
                    maxAttendences = attendences;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendences} lectures.");
        }
    }
}
