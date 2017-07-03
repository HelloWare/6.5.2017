using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HelloWareAcademy;

namespace MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("2002 ....", "Dao Lang");
            Song song2 = new Song("Zhengfu", "Naying");

            MusicPlayer musicPlayer = new MusicPlayer();
            musicPlayer.PlayList.Add(song1);
            musicPlayer.PlayList.Add(song2);
            musicPlayer.PlayAllSongs();

            Utility.ShowTestMessage();
        }
    }

    class MusicPlayer
    {
        protected List<Song> playList = new List<Song>();

        public List<Song> PlayList
        {
            get
            {
                return playList;
            }

            set
            {
                playList = value;
            }
        }

        public void PlayAllSongs()
        {
            foreach (Song song in playList)
            {
                Console.WriteLine("Now playing song: {0} by {1}", song.Name, song.Auther);
                Thread.Sleep(5000);
            }
        }
    }

    class Song
    {
        private string name;
        private string author;

        public Song(string name,string author)
        {
            this.name = name;
            this.author = author;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Auther
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }
    }
}
