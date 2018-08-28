using System;
using System.Collections.Generic;

namespace family_dictionary
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

      myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Drew"},
                {"age", "31"}
        });
      myFamily.Add("mom", new Dictionary<string, string>() {
        { "name", "Dee"},
            { "age", "59"}
      });
      myFamily.Add("dad", new Dictionary<string, string>(){
          {"name", "Dennis"},
          {"age", "61"}
      });

      foreach (KeyValuePair<string, Dictionary<string, string>> person in myFamily)
      {
        Console.WriteLine($"{person.Value["name"]} is my {person.Key} and is {person.Value["age"]} years old.");
      }
    }
  }
}
