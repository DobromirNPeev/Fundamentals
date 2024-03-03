using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Songs
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public int Minutes { get; set; }
        public  int Seconds { get; set; }
        public Songs(string typeList, string name, int minutes,int seconds)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Songs> newSong = new List<Songs>();
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split('_');
                string typeList = input[0];
                string name = input[1];
                string[] time = input[2].Split(':');
                int minutes = int.Parse(time[0]);
                int seconds = int.Parse(time[1]);
                Songs song = new Songs (typeList, name, minutes, seconds);
                newSong.Add(song);
            }
            string command = Console.ReadLine();
            if (command == "all")
            {
                foreach(var item in newSong)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                List<Songs> filteredSongs = newSong.FindAll(Songs => Songs.TypeList == command);
                foreach (var item in filteredSongs)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
