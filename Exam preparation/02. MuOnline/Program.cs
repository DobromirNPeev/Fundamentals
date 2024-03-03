using System;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dungeons = Console.ReadLine().Split('|').ToArray();
            int health = 100;
            int bitcoins = 0;
            int bestRoom = 0;
            bool isKilled = false;
            for (int i = 0; i < dungeons.Length; i++)
            {
                string[] currRoom = dungeons[i].Split().ToArray();
                string command = currRoom[0];
                int number = int.Parse(currRoom[1]);
                if (command == "potion")
                {
                    int needed = 100 - health;
                    if (number > needed)
                    {
                        number = needed;
                    }
                    Console.WriteLine($"You healed for {number} hp.");
                    health += number;
                    if (health > 100) health = 100;
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                {
                    bitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else
                {
                    health -= number;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        isKilled = true;
                        Console.WriteLine($"You died! Killed by {command}.");
                        bestRoom = i+1;
                        Console.WriteLine($"Best room: {bestRoom}");
                        break;
                    }
                }
            }
            if (!isKilled)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
