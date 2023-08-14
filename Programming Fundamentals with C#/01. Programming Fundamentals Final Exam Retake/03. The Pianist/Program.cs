using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    class Song
    {
        public string Piece { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }

        public Song(string piece, string composer, string key)
        {
            Piece = piece;
            Composer = composer;
            Key = key;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = string.Empty;
            List<Song> songs = new List<Song>();


            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine();
                string[] tokens = line.Split('|');
                Song song = new Song(tokens[0], tokens[1], tokens[2]);
                songs.Add(song);
            }

            while ((line = Console.ReadLine()) != "Stop")
            {
                string[] tokens = line.Split('|');

                if (tokens[0] == "Add")
                {
                    if (songs.Any(x => x.Piece == tokens[1]))
                    {
                        var first = songs.First(x => x.Piece == tokens[1]);
                        Console.WriteLine($"{first.Piece} is already in the collection!");
                    }

                    else
                    {
                        Song song = new Song(tokens[1], tokens[2], tokens[3]);
                        Console.WriteLine($"{tokens[1]} by {tokens[2]} in {tokens[3]} added to the collection!");
                        songs.Add(song);
                    }
                }

                else if (tokens[0] == "Remove")
                {
                    if (!songs.Any(x => x.Piece == tokens[1]))
                    {
                        Console.WriteLine($"Invalid operation! {tokens[1]} does not exist in the collection.");
                    }

                    else
                    {
                        var first = songs.First(x => x.Piece == tokens[1]);
                        songs.Remove(first);
                        Console.WriteLine($"Successfully removed {tokens[1]}!");
                    }
                }

                else if (tokens[0] == "ChangeKey")
                {
                    if (songs.Any(x => x.Piece == tokens[1]))
                    {
                        var first = songs.First(x => x.Piece == tokens[1]);
                        first.Key = tokens[2];
                        Console.WriteLine($"Changed the key of {tokens[1]} to {tokens[2]}!");
                    }

                    else
                    {
                        Console.WriteLine($"Invalid operation! {tokens[1]} does not exist in the collection.");
                    }
                }
            }

            foreach (Song song in songs)
            {
                Console.WriteLine($"{song.Piece} -> Composer: {song.Composer}, Key: {song.Key}");
            }
        }
    }
}
