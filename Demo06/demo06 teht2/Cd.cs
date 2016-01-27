using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo06_teht2
{
    class Cd
    {
        private List<Song> songs;
        public double Prize { get; set; }
        public void Songs()
        {
            songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }
        public void PrintCollection()
        {
            Console.WriteLine("Song and time: ");
            foreach (Song song in songs)
            {
                Console.WriteLine(song.ToString());
            }
        }

    }
}
