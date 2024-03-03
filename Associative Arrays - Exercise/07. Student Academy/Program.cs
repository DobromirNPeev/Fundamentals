using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> studentsGrades = new Dictionary<string, double>();
            Dictionary<string, int> studentsGradesCount = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade =double.Parse(Console.ReadLine());
                if (studentsGrades.ContainsKey(name))
                {
                    studentsGrades[name] += grade;
                    studentsGradesCount[name] += 1;
                }
                else
                {
                    studentsGrades.Add(name, grade);
                    studentsGradesCount.Add(name, 1);
                }
            }
            Dictionary<string, double> finaldDic = new Dictionary<string, double>();
            foreach (var item in studentsGrades)
            {
                foreach (var itemInside in studentsGradesCount)
                {
                    if (item.Key == itemInside.Key)
                    {
                        if (item.Value / itemInside.Value >= 4.5)
                        {
                            double avg = item.Value / itemInside.Value;
                            finaldDic.Add(item.Key, avg);
                            break;
                        }
                    }
                }
            }
            foreach (var item in finaldDic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
