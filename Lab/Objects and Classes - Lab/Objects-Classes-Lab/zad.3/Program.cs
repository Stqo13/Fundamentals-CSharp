using System;
using System.Linq;
using System.Collections.Generic;

namespace zad._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] songInfo = Console.ReadLine().Split('_');
                string typeList = songInfo[0];
                string name = songInfo[1];
                string time = songInfo[2];
                Song song = new Song(typeList, name, time);
                songs.Add(song);
            }
            string command = Console.ReadLine();
            for (int i = 0; i < songs.Count; i++)
            {
                Song currentSong = songs[i];
                if (command=="all")
                {
                    Console.WriteLine(currentSong.Name);
                }
                else if (command==currentSong.TypeList)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }
        }
        public class Song
        {
            public Song(string typeList, string name, string time)
            {
                TypeList = typeList;
                Name = name;
                Time = time;
            }
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string Time { get; set; }
        }
    }
}
