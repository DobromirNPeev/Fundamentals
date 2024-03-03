using System;

namespace _01._Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodKg = double.Parse(Console.ReadLine());
            double hayKg = double.Parse(Console.ReadLine());
            double coverKg = double.Parse(Console.ReadLine());
            double weightKg = double.Parse(Console.ReadLine());
            foodKg *= 1000;
            hayKg *= 1000;
            coverKg *= 1000;
            weightKg *= 1000;
            double oneThird = weightKg / 3;
            bool enough = true;
            for (int i = 1; i <= 30; i++)
            {
                foodKg -= 300;
                if (i % 2 == 0)
                {
                    double leftHay = foodKg * 0.05;
                    hayKg -= leftHay;
                }
                if (i % 3 == 0)
                {
                    coverKg -= oneThird;
                }
                if (hayKg < 0 || coverKg < 0 || foodKg < 0)
                {
                    enough = false;
                    Console.WriteLine("Merry must go to the pet store!");
                    break;
                }
            }
            if (enough)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodKg/1000:f2}, Hay: {hayKg/1000:f2}, Cover: {coverKg/1000:f2}.");
            }
        }
    }
}
