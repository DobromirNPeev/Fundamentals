using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Position
    {
        public string PosName { get; set; }
        public int Skills { get; set; }
        public Position(string posName,int skills)
        {
            this.PosName = posName;
            this.Skills = skills;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Position>> players = new Dictionary<string, List<Position>>();
            string input = string.Empty;
            while((input=Console.ReadLine())!= "Season end")
            {

                string player1 = string.Empty;
                string player2 = string.Empty;
                string player = string.Empty;
                string position = string.Empty;
                int skills = -1;
                bool fight = false;
                if (input.Contains("vs"))
                {
                    string[] inputAsArray = input.Split(" vs ").ToArray();
                    player1 = inputAsArray[0];
                    player2 = inputAsArray[1];
                    fight = true;
                }
                else
                {
                    string[] inputAsArray = input.Split(" -> ").ToArray();
                    player = inputAsArray[0];
                    position = inputAsArray[1];
                    skills = int.Parse(inputAsArray[2]);
                }
                Position currPos = new Position(position, skills);
                if (!fight)
                {
                    if (!players.Keys.Contains(player))
                    {
                        List<Position> adding = new List<Position>
                        {
                            currPos
                        };
                        players.Add(player, adding);
                    }
                    else
                    {
                        bool changed = false;
                        foreach (var item in players[player])
                        {
                            if (item.PosName == position)
                            {
                                changed = true;
                                break;
                            }
                        }
                        if (changed) break;
                        changed = false;
                        foreach (var item in players[player])
                        {
                            if (item.Skills < skills && item.PosName == position)
                            {
                                changed = true;
                                item.Skills = skills;
                            }
                        }
                        if (!changed)
                        {
                            players[player].Add(currPos);
                        }
                    }
                }
                else
                {
                    if (players.ContainsKey(player1) && players.ContainsKey(player2))
                    {
                        bool removed = false;
                        foreach (var item in players[player1])
                        {
                            if (removed)
                            {
                                break;
                            }
                            else
                            {
                                foreach (var itemInside in players[player2])
                                {
                                    if (item.PosName == itemInside.PosName)
                                    {
                                        removed = true;
                                        if (players[player1].Sum(x=>x.Skills) > players[player2].Sum(x => x.Skills))
                                        {
                                            players.Remove(player2);
                                            break;
                                        }
                                        else if (players[player1].Sum(x => x.Skills) < players[player2].Sum(x => x.Skills))
                                        {
                                            players.Remove(player1);
                                            break;
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }
                                }
                            }                           
                        }
                    }
                }
            }
            foreach (var item in players.OrderByDescending(x=>x.Value.Sum(x=>x.Skills)).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Sum(x=>x.Skills)} skill");
                List<Position> ordered = item.Value.OrderByDescending(x => x.Skills).ThenBy(x => x.PosName).ToList();
                foreach (var itemInside in ordered)
                {
                    Console.WriteLine($"- {itemInside.PosName} <::> {itemInside.Skills}");
                }
            }
        }
    }
}
