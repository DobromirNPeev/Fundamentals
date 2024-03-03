using System;
using System.Collections.Generic;

namespace Problem_3___P_rates
{
    class City
    {
        public int Population { get; set; }
        public int Gold { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] inputAsArray = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string name = inputAsArray[0];
                int population = int.Parse(inputAsArray[1]);
                int gold = int.Parse(inputAsArray[2]);
                if (!cities.ContainsKey(name))
                {
                    City currCity = new City
                    {
                        Population = population,
                        Gold = gold
                    };
                    cities.Add(name, currCity);
                }
                else
                {
                    cities[name].Population += population;
                    cities[name].Gold += gold;
                }
            }
            string action = string.Empty;
            while ((action = Console.ReadLine()) != "End")
            {
                string[] actionAsArray = action.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string command = actionAsArray[0];
                if (command == "Plunder")
                {
                    string name = actionAsArray[1];
                    int population = int.Parse(actionAsArray[2]);
                    int gold = int.Parse(actionAsArray[3]);
                    cities[name].Population -= population;
                    cities[name].Gold -= gold;
                    Console.WriteLine($"{name} plundered! {gold} gold stolen, {population} citizens killed.");
                    if (cities[name].Gold <= 0 || cities[name].Population <= 0)
                    {
                        cities.Remove(name);
                        Console.WriteLine($"{name} has been wiped off the map!");
                    }
                }
                else
                {
                    string name = actionAsArray[1];
                    int gold = int.Parse(actionAsArray[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    cities[name].Gold += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {name} now has {cities[name].Gold} gold.");
                }
            }
            if (cities.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var item in cities)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value.Population} citizens, Gold: {item.Value.Gold} kg");
                }
            }
        }
    }
}
