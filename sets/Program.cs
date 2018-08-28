using System;
using System.Collections.Generic;

namespace sets
{
  class Program
  {
    static void Main(string[] args)
    {
      HashSet<string> Showroom = new HashSet<string>();
      Showroom.Add("Camry");
      Showroom.Add("Altima");
      Showroom.Add("Prizm");
      Showroom.Add("Corolla");
      Showroom.Add("F150");

      Console.WriteLine($"I have {Showroom.Count} cars on display today.");

      Showroom.Add("Camry");

      HashSet<string> UsedLot = new HashSet<string>();
      UsedLot.Add("Sentra");
      UsedLot.Add("Xterra");

      Showroom.UnionWith(UsedLot);
      Console.WriteLine(Showroom.Count);
      Showroom.Remove("F150");

      HashSet<string> Junkyard = new HashSet<string>();
      Junkyard.Add("Camry");
      Junkyard.Add("XB");
      Junkyard.Add("Sonata");

      HashSet<string> clone = new HashSet<string>(Showroom);
      clone.IntersectWith(Junkyard);
      foreach (string item in clone)
      {
        Console.WriteLine($"After intersection {item}");
      }
      Showroom.UnionWith(Junkyard);

      Console.WriteLine(Showroom.Count);
      foreach (string item in Showroom)
      {
        Console.WriteLine(item);
      }
    }
  }
}

