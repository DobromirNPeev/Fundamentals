using System;

namespace _15._Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int count = 1;
            string winner = string.Empty;
            string nameOfTheAttack = string.Empty;
            string nameOfTheAttacker = string.Empty;
            string nameOfTheDefending = string.Empty;
            int peshoHealth = 100;
            int goshoHealth = 100;
            while(peshoHealth>0 && goshoHealth > 0)
            {
                if (count % 2 == 0)
                {
                    nameOfTheAttack = "Thunderous fist";
                    nameOfTheAttacker = "Gosho";
                    nameOfTheDefending = "Pesho";
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0) break;
                    Console.WriteLine($"{nameOfTheAttacker} used {nameOfTheAttack} and reduced {nameOfTheDefending} to {peshoHealth} health.");
                }
                else if (count % 2 == 1)
                {
                    nameOfTheAttack = "Roundhouse kick";
                    nameOfTheAttacker = "Pesho";
                    nameOfTheDefending = "Gosho";
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0) break;
                    Console.WriteLine($"{nameOfTheAttacker} used {nameOfTheAttack} and reduced {nameOfTheDefending} to {goshoHealth} health.");
                }
                if (count % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }
                count++;
            }
            if (peshoHealth <= 0)
            {
                winner = "Gosho";
            }
            else if (goshoHealth <= 0)
            {
                winner = "Pesho";
            }
            Console.WriteLine($"{winner} won in {count}th round.");
        }
    }
}
