using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _03._Songs
{
    class Songs
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

        public Songs()
        {
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());
            List<Songs> songs = new List<Songs>();

            for (int i = 0; i < songsCount; i++)
            {
                Songs song = new Songs();
                string[]input = Console.ReadLine().Split('_');

                song.TypeList = input[0];
                song.Name = input[1];
                song.Time = input[2];

                songs.Add(song);

            }

            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (Songs song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }

            else
            {
                foreach (Songs song in songs)
                {
                    if (typeList == song.TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

        }
    }
}
