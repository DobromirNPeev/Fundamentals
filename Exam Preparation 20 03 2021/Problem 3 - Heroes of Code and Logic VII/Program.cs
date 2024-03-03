using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Heroes_of_Code_and_Logic_VII
{
    class HeroProps
    {
        public int HP { get; set; }
        public int MP { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HeroProps> heroes = new Dictionary<string, HeroProps>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] currHero = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = currHero[0];
                int hp= int.Parse(currHero[1]);
                int mp= int.Parse(currHero[2]);
                HeroProps currHeroProps = new HeroProps
                {
                    HP = hp,
                    MP = mp
                };
                heroes.Add(name, currHeroProps);
            }
            string commandInput = string.Empty;
            while ((commandInput = Console.ReadLine()) != "End")
            {
                string[] commandAsArray = commandInput.Split(" - ");
                string command = commandAsArray[0];
                if(command=="CastSpell")
                {
                    string hero = commandAsArray[1];
                    int MPneeded = int.Parse(commandAsArray[2]);
                    string spellName = commandAsArray[3];
                    if (heroes[hero].MP - MPneeded >= 0)
                    {
                        heroes[hero].MP -= MPneeded;
                        Console.WriteLine($"{hero} has successfully cast {spellName} and now has {heroes[hero].MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command == "TakeDamage")
                {
                    string hero = commandAsArray[1];
                    int damage = int.Parse(commandAsArray[2]);
                    string attacker = commandAsArray[3];
                    heroes[hero].HP -= damage;
                    if (heroes[hero].HP > 0)
                    {
                        Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {heroes[hero].HP} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{hero} has been killed by {attacker}!");
                        heroes.Remove(hero);
                    }
                }
                else if (command == "Recharge")
                {
                    string hero = commandAsArray[1];
                    int amount = int.Parse(commandAsArray[2]);
                    if (heroes[hero].MP + amount > 200)
                    {
                        Console.WriteLine($"{hero} recharged for {200-heroes[hero].MP} MP!");
                        heroes[hero].MP = 200;
                    }
                    else
                    {
                        Console.WriteLine($"{hero} recharged for {amount} MP!");
                        heroes[hero].MP += amount;
                    }
                }
                else
                {
                    string hero = commandAsArray[1];
                    int amount = int.Parse(commandAsArray[2]);
                    if (heroes[hero].HP +amount> 100)
                    {
                        Console.WriteLine($"{hero} healed for {100-heroes[hero].HP} HP!");
                        heroes[hero].HP = 100;
                    }
                    else
                    {
                        Console.WriteLine($"{hero} healed for {amount} HP!");
                        heroes[hero].HP += amount;
                    }
                }
            }
            foreach (var item in heroes)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"  HP: {item.Value.HP}");
                Console.WriteLine($"  MP: {item.Value.MP}");
            }
        }
    }
}
