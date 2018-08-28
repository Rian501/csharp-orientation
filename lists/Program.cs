using System;
using System.Collections.Generic;

namespace lists
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> planetList = new List<string>() { "Mercury", "Mars" };

      planetList.Add("Saturn");
      planetList.Add("Jupiter");

      List<string> lastTwoPlanets = new List<string>() { "Neptune", "Uranus" };
      planetList.AddRange(lastTwoPlanets);
      planetList.Insert(1, "Venus");
      planetList.Insert(2, "Earth");
      planetList.Add("Pluto");

      List<string> rockyPlanets = new List<string>();
      rockyPlanets.AddRange(planetList.GetRange(0, 4));
      planetList.Remove("Pluto");

      Dictionary<string, string> mercury = new Dictionary<string, string>();
      Dictionary<string, string> venus = new Dictionary<string, string>();
      Dictionary<string, string> mars = new Dictionary<string, string>();
      Dictionary<string, string> jupiter = new Dictionary<string, string>();
      Dictionary<string, string> saturn = new Dictionary<string, string>();
      Dictionary<string, string> uranus = new Dictionary<string, string>();
      Dictionary<string, string> neptune = new Dictionary<string, string>();
      Dictionary<string, string> pluto = new Dictionary<string, string>();
      venus["Venera 1"] = "Venus"; //can also do it this way!
      venus.Add("Sputnik 19", "Venus");
      venus.Add("Cosmos 21", "Venus");
      venus.Add("Vega 1", "Venus");
      venus.Add("Galileo", "Venus");
      venus.Add("Magellan", "Venus");
      venus.Add("Cassini", "Venus");
      mercury.Add("Mariner 10", "Mercury");
      mercury.Add("Messenger", "Mercury");
      mars.Add("Mariner 8", "Mars");
      mars.Add("Zond 2", "Mars");
      mars.Add("Mars 4", "Mars");
      mars.Add("Viking 1", "Mars");
      jupiter.Add("Juno", "Jupiter");
      jupiter.Add("Cassini", "Jupiter");
      jupiter.Add("Pioneer 10", "Jupiter");
      jupiter.Add("Voyager 1", "Jupiter");
      saturn.Add("Voyager 1", "Saturn");
      saturn.Add("Voyager 2", "Saturn");
      saturn.Add("Pioneer 11", "Saturn");
      saturn.Add("Cassini", "Saturn");
      uranus.Add("Voyager 2", "Uranus");
      neptune.Add("Voyager 2", "Neptune");
      pluto.Add("New Horizons", "Pluto");

      List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
      probes.Add(mercury);
      probes.Add(venus);
      probes.Add(mars);
      probes.Add(jupiter);
      probes.Add(saturn);
      probes.Add(uranus);
      probes.Add(neptune);
      probes.Add(pluto);


      foreach (string planet in planetList)
      {
        string planetProbesString = new string($"{planet}: ");
        foreach (Dictionary<string, string> probe in probes)
        {
          foreach (KeyValuePair<string, string> item in probe)
          {
            if (item.Value == planet)
            {
              planetProbesString = $"{planetProbesString} {item.Key},";
            }

          }
        }
        //only print stuff that has probes
        if (planetProbesString.Contains(","))
        {
          //cut off trailing comma
          string output = planetProbesString.Substring(0, planetProbesString.Length - 1);
          Console.WriteLine(output);
        }
      }
    }
  }
}

// https://github.com/nss-day-cohort-26/planets-exercise/blob/master/Program.cs
// Steve's example
