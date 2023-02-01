using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1A
{
    internal class Album
    {
        private string albumName;
        private string artistName;
        private int numOfTracks;

        public void Start()
        {
            AlbumStart();
            Questions();
            DisplayAnswers();
        }

        public void Questions()
        {
            Console.WriteLine("What is the name of your favorite music album?");
            albumName = Console.ReadLine();
            Console.WriteLine("What is the name of the Artist or Band for " + albumName + "?");
            artistName = Console.ReadLine();
            Console.WriteLine("How many tracks does " + albumName + "have?");
            numOfTracks = int.Parse(Console.ReadLine());
        }
        public void DisplayAnswers()
        {
            string answers = "Album Name: " + albumName + "\n" + "Artist/Band: " + artistName + "\n" + "Number of Tracks: " + numOfTracks + "\n" + "Enjoy listening!";
            Console.WriteLine(answers);
        }
        
        public void AlbumStart()
        {
            string starting = "Starting the Album Program!";
            Console.WriteLine(starting);
        }


    }
}
