using System;
using System.Collections.Generic;


namespace nickleback
{
  class Program
  {
    static void Main(string[] args)
    {

      //       Define a List, named goodSongs, that will hold tuples consisting of two strings.
      List<(string artist, string title)> goodSongs = new List<(string, string)>();

      // Define a HashSet, named allSongs, that contains 7 tuples.Each tuple should contain two string values:

      // The name of an artist
      // A song by that artist

      HashSet<(string name, string song)> songs = new HashSet<(string, string)>(){
      ("Nickelback", "Photograph"),
      ("Hanson", "Mmmbop"),
      ("Journey", "Lovin' Touchin' Squeezin'"),
      ("Cake", "Short Skirt Long Jacket"),
      ("Ben Folds", "Still Fighting It"),
      ("Nickelback", "Your Face"),
      ("Rachmaninoff", "D minor"),

      };
      // Once the set is populated with 7 tuples, iterate over the set of songs, and check if the band name is "Nickelback".
      foreach ((string name, string song) song in songs)
      {
        if (song.name != "Nickelback")
        {
          // If the band is not Nickelback, then add it to the goodSongs list.
          goodSongs.Add(song);
        }
      }

      // Use another foreach loop to print out all the good songs.
      foreach (var song in goodSongs)
      {
        Console.WriteLine($"{song.title} by {song.artist}");
      }
    }
  }
}
