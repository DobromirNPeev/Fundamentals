using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warship = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            string command = string.Empty;
            bool isPirateShipSunk = false;
            bool isStalemate = true;
            while ((command = Console.ReadLine()) != "Retire")
            {
                string[] commandS = command.Split(" ").ToArray();
                string type = commandS[0];
                if (type == "Fire")
                {
                    int index = int.Parse(commandS[1]);
                    int damage = int.Parse(commandS[2]);
                    Fire(warship, index, damage);
                    if (index < 0 || index >= warship.Count)
                    {
                        continue;
                    }
                    if (warship[index] <= 0)
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        isStalemate = false;
                        break;
                    }
                }
                else if (type == "Defend")
                {
                    int startIndex = int.Parse(commandS[1]);
                    int endIndex = int.Parse(commandS[2]);
                    int damage = int.Parse(commandS[3]);
                    Defend(pirateShip, startIndex, endIndex, damage);
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] <= 0)
                        {
                            isPirateShipSunk = true;
                            break;
                        }
                    }
                    if (isPirateShipSunk)
                    {
                        isStalemate = false;
                        break;
                    }
                }
                else if (type == "Repair")
                {
                    int index = int.Parse(commandS[1]);
                    int health = int.Parse(commandS[2]);
                    Repair(pirateShip, index, health, maxHealth);
                }
                else if (type == "Status")
                {
                    Status(pirateShip, maxHealth);
                }
            }
            if (isStalemate)
            {
                Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
                Console.WriteLine($"Warship status: {warship.Sum()}");
            }
        }
        static void Fire(List<int> warship, int index, int damage)
        {
            if (index < 0 || index >= warship.Count) return;
            warship[index] -= damage;
        }
        static void Defend(List<int> pirateShip, int startIndex, int endIndex, int damage)
        {
            if (startIndex < 0 || endIndex >= pirateShip.Count || startIndex>=pirateShip.Count || endIndex<0) return;
            bool isPirateShipSunk = false;
            for (int i = startIndex; i <= endIndex; i++)
            {
                pirateShip[i] -= damage;
                if (pirateShip[i] <= 0)
                {
                    isPirateShipSunk = true;
                }
            }
            if (isPirateShipSunk)
            {
                Console.WriteLine("You lost! The pirate ship has sunken.");
            }
        }
        static void Repair(List<int> pirateShip,int index,int health,int maxHealth)
        {
            if (index < 0 || index >= pirateShip.Count) return;
            pirateShip[index] += health;
            if (pirateShip[index] > maxHealth)
            {
                pirateShip[index] = maxHealth;
            }
        }
        static void Status(List<int> pirateShip,int maxHealth)
        {
            int count = 0;
            double needRepair = maxHealth * 0.2f;
            for (int i = 0; i < pirateShip.Count; i++)
            {
                if (pirateShip[i] < needRepair)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} sections need repair.");
        }
    }
}
