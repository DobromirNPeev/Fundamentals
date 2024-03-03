using System;
using System.Collections.Generic;

namespace _03._Plant_Discovery
{
    class PlantAtt
    {
        public int Rarity { get; set; }
        public double Rating { get; set; }
        public double Counter { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, PlantAtt> plants = new Dictionary<string, PlantAtt>();
            for (int i = 0; i < n; i++)
            {
                string[] currPlant = Console.ReadLine().Split("<->");
                string name = currPlant[0];
                int rarity = int.Parse(currPlant[1]);
                if (plants.ContainsKey(name))
                {
                    plants[name].Rarity = rarity;
                }
                else
                {
                    PlantAtt curr = new PlantAtt
                    {
                        Rarity = rarity,
                        Rating = 0,
                        Counter = 0
                    };
                    plants.Add(name, curr);
                }
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Exhibition")
            {
                string[] inputArray = input.Split(": ");
                if (inputArray[0] == "Rate")
                {
                    string[] spliting = inputArray[1].Split(" - ");
                    string plant = spliting[0];
                    if (!plants.ContainsKey(plant))
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    int rating = int.Parse(spliting[1]);
                    plants[plant].Rating += rating;
                    plants[plant].Counter++;
                }
                else if(inputArray[0] == "Update")
                {
                    string[] spliting = inputArray[1].Split(" - ");
                    string plant = spliting[0];
                    if (!plants.ContainsKey(plant))
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    int newRarity = int.Parse(spliting[1]);
                    plants[plant].Rarity = newRarity;
                }
                else
                {
                    string plant = inputArray[1];
                    if (!plants.ContainsKey(plant))
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    plants[plant].Rating =0;
                    plants[plant].Counter =0;
                }
            }
            Console.WriteLine($"Plants for the exhibition:");
            foreach (var item in plants)
            {
                double divide = item.Value.Rating / item.Value.Counter;
                if (Double.IsNaN(divide))
                {
                    divide = 0;
                }
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {divide:f2}");
            }
        }
    }
}

