using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Songs
{
    class Song
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Time { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] lineParmas = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);

                Song newSong = new Song()
                {
                    Name = lineParmas[1],
                    Type = lineParmas[0],
                    Time = lineParmas[2],
                };

                songs.Add(newSong);
            }

            string filterValue = Console.ReadLine();

            if (filterValue == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }

                // LINQ way
                //Console.WriteLine(string
                //    .Join(Environment.NewLine, songs
                //        .Select(song => song.Name)));
            }
            else
            {
                var filteredSongs = songs.FindAll(x => x.Type == filterValue);

                foreach (var song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }

                // LINQ way
                //Console.WriteLine(string
                //    .Join(Environment.NewLine, filteredSongs
                //        .Select(song => song.Name)));
            }
        }
    }
}
