using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Team
    {
        public List<string> Users { get; set; }
        public string Creators{ get; set; }
        public string TeamName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < countOfTeams; i++)
            {
                string[] creation = Console.ReadLine().Split('-');
                string creator = creation[0];
                string teamName = creation[1];
                List<string> users = new List<string>();
                bool isExecutable = true;
                Team currTeam = new Team
                {
                    Creators = creator,
                    TeamName = teamName,
                    Users=users
                };
                foreach (var item in teams)
                {
                    if (item.TeamName == currTeam.TeamName)
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                        isExecutable = false;
                        break;
                    }
                    if (item.Creators==currTeam.Creators)
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                        isExecutable = false;
                        break;
                    }
                }
                if (isExecutable)
                {
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    teams.Add(currTeam);                   
                }
            }
            string joiningTheTeam = string.Empty;
            while ((joiningTheTeam = Console.ReadLine()) != "end of assignment")
            {
                string[] joiningTheTeamAsArray = joiningTheTeam.Split("->");
                string user = joiningTheTeamAsArray[0];
                string team = joiningTheTeamAsArray[1];
                bool NonExistent = false;
                bool AlreadyJoined = false;
                foreach (var item in teams)
                {
                    if (item.TeamName.Contains(team))
                    {
                        NonExistent = true;
                    }
                    if ((item.Users.Contains(user) && team != item.TeamName) || (item.Creators == user && team == item.TeamName))
                    {
                        AlreadyJoined = true;
                    }
                }
                if (!NonExistent)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }
                if (AlreadyJoined)
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                    continue;
                }
                foreach (var item in teams)
                {
                    if (item.TeamName == team)
                    {
                        item.Users.Add(user);
                    }
                }
            }
            List<Team> disband = new List<Team>();
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].Users.Count ==0)
                {
                    disband.Add(teams[i]);
                    teams.Remove(teams[i]);
                    i = -1;
                }
            }
            teams = teams.OrderByDescending(x => x.Users.Count).ThenBy(x => x.TeamName).ToList();
            foreach (var item in teams)
            {
                Console.WriteLine($"{item.TeamName}");
                Console.WriteLine($"- {item.Creators}");
                item.Users = item.Users.OrderBy(x => x).ToList();
                foreach (var item1 in item.Users)
                {
                    Console.WriteLine($"-- {item1}");
                }
            }
            disband = disband.OrderBy(x => x.TeamName).ToList();
            Console.WriteLine("Teams to disband:");
            foreach (var item in disband)
            {
                Console.WriteLine(item.TeamName);
            }
        }
    }
}
