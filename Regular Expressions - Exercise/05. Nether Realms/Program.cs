using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Demon
    {
        public int Health { get; set; }
        public double Damage { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Demon> allDemons = new SortedDictionary<string, Demon>();
            string healthReg = @"[^\d+\+\-\*\/\.]";
            //string damageReg = @"(\d+.(\d+))|(-(\d+.(\d+)))|(\d+)|(-(\d+))|\*|\/";
            string damageReg = @"\-?[0-9\.]+";
            string actions = @"[\*\/]";
            string[] demons = Console.ReadLine().Split(new char[]{',',' '},StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < demons.Length; i++)
            {
                MatchCollection healthRegexed = Regex.Matches(demons[i], healthReg);
                int health = 0;
                for (int j = 0; j < healthRegexed.Count; j++)
                {
                    char character = char.Parse(healthRegexed[j].ToString());
                    health += character;
                }
                MatchCollection damageRegexed = Regex.Matches(demons[i], damageReg);
                MatchCollection currActions = Regex.Matches(demons[i],actions);
                double damage = 0;
                for (int j = 0; j < damageRegexed.Count; j++)
                {
                    string character = damageRegexed[j].ToString();
                    if (character == "*" || character == "/")
                    {
                        actions += character;
                    }
                    else
                    {
                        damage += double.Parse(character);
                    }
                }
                for (int j = 0; j < currActions.Count; j++)
                {
                    if (currActions[j].ToString() == "*")
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }
                Demon currDemon = new Demon
                {
                    Health = health,
                    Damage = damage
                };
                allDemons.Add(demons[i], currDemon);
            }
            foreach (var item in allDemons)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Health} health, {item.Value.Damage:f2} damage");
            }
        }
    }
}
