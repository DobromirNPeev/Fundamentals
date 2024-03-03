using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyPer100ml = int.Parse(Console.ReadLine());
            var sugarPer100ml = int.Parse(Console.ReadLine());
            double energy = ((double)energyPer100ml / 100) * volume;
            double sugar = ((double)sugarPer100ml / 100) * volume;
            Console.WriteLine($"{volume}ml {name}");
            Console.WriteLine($"{energy:f2}kcal, {sugar:f2}g sugars");
        }
    }
}
