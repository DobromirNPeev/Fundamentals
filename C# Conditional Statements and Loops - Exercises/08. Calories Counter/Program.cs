using System;

namespace _08._Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
                for (int i = 0; i < n; i++)
            {
                string ingre = Console.ReadLine();
                if (ingre.ToLower().Contains("cheese"))
                {
                    sum += 500;
                }
                else if(ingre.ToLower().Contains("tomato sauce"))
                {
                    sum += 150;
                }
                else if (ingre.ToLower().Contains("salami"))
                {
                    sum += 600;
                }
                else if (ingre.ToLower().Contains("pepper"))
                {
                    sum += 50;
                }
            }
            Console.WriteLine($"Total calories: {sum}");
        }
    }
}
