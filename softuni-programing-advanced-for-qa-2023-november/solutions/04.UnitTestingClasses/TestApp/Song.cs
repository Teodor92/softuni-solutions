using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp;

public class Song
{
    public string ListType { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Time { get; set; } = null!;
    
    public string AddAndListSongs(string[] songs, string wantedList)
    {
        List<Song> addedSongs = new();

        foreach (string currentSong in songs)
        {
            string[] data = currentSong.Split('_');

            string type = data[0];
            string name = data[1];
            string time = data[2];

            Song song = new()
            {
                ListType = type,
                Name = name,
                Time = time
            };

            addedSongs.Add(song);
        }

        List<Song> filtered = wantedList == "all"
            ? addedSongs
            : addedSongs.Where(s => s.ListType == wantedList).ToList();

        StringBuilder sb = new();
        foreach (Song song in filtered)
        {
            sb.AppendLine(song.Name);
        }

        return sb.ToString().Trim();
    }
}
