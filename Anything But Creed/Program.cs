using System;
using System.Collections.Generic;
using System.Linq;

namespace Anything_But_Creed
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Define a List, named goodSongs, that will hold instances of Song.
            var goodSongs = new List<Song>();

            // Define a List, named allSongs, that contains 12 instances of Song.
            // Make sure that some of the songs are from the band Creed.
            var allSongs = new List<Song>
            {
                new Song("Queen", "Don't Stop Me Now"),
                new Song("The Jackson 5", "I Want You Back"),
                new Song("Olivia Newton-John", "Physical"),
                new Song("Creed", "Arms Wide Open"),
                new Song("Creed", "Higher"),
                new Song("Creed", "One Last Breath"),
                new Song("The Police", "Every Breath You Take"),
                new Song("Michael Jackson", "Billie Jean"),
                new Song("Kenny Rogers", "Lady"),
                new Song("Prince", "When Doves Cry"),
                new Song("Van Halen", "Jump"),
                new Song("The Bangles", "Walk Like an Egyptian")
            };
            // Console.WriteLine($"Test: {allSongs[0].Name}");

            // Once the set is populated with 12 instances of Song, use Linq to filter the allSongs list for
            // songs where the artist is NOT Creed. Set goodSongs equal to the filtered result.
            var creedSongs = allSongs.Where(s => s.Artist == "Creed");
            foreach (var song in creedSongs)
            {
                Console.WriteLine($"Creed song: {song.Name}");
            }

            goodSongs.AddRange(allSongs.Except(creedSongs));

            // Loop to print out all the good songs.

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"Good song: {song.Name} by {song.Artist}");
            }
        }
    }
}
