using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    class Dragon
    {
        public double Damage { get; set; }
        public double Health { get; set; }
        public double Armor { get; set; }
        public Dragon(double damage,double health,double armor)
        {
            this.Damage = damage;
            this.Health = health;
            this.Armor = armor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,SortedDictionary<string,Dragon>> dragons = new Dictionary<string, SortedDictionary<string, Dragon>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                string type = input[0];
                string name = input[1];
                double damage = 0;
                double health = 0;
                double armor = 0;
                SortedDictionary<string, Dragon> currDragon = new SortedDictionary<string, Dragon>();
                if (input[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = double.Parse(input[2]);
                }
                if (input[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = double.Parse(input[3]);
                }
                if (input[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = double.Parse(input[4]);
                }
                Dragon newDragon = new Dragon(damage, health, armor);
                currDragon.Add(name, newDragon);
                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, currDragon);
                }
                else
                {
                    if (dragons[type].ContainsKey(name))
                    {
                        bool thereIs = false;
                        foreach (var item in dragons[type])
                        {
                            if (item.Key == name)
                            {
                                thereIs = true;
                            }
                        }
                        if (thereIs)
                        {
                            dragons[type].Remove(name);
                            dragons[type].Add(name, newDragon);
                        }
                    }
                    else
                    {
                        dragons[type].Add(name, newDragon);
                    }
                }
            }
            foreach (var item in dragons)
            {
                Console.WriteLine($"{item.Key}::({ item.Value.Average(x=>x.Value.Damage):f2}/{  item.Value.Average(x => x.Value.Health):f2}/{item.Value.Average(x => x.Value.Armor):f2})");
                foreach (var itemNested in item.Value)
                {
                    Console.WriteLine($"-{itemNested.Key} -> damage: {itemNested.Value.Damage}, health: {itemNested.Value.Health}, armor: {itemNested.Value.Armor}");
                }
            }
        }
    }
}
