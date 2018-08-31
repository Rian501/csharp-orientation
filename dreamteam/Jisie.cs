using System;
namespace dreamteam
{
  public class Jisie : IPerson
  {
    public string Specialty = "Ruby";
    public string FirstName = "Jisie";
    public string LastName = "David";
    public string Name { get => $"{FirstName} {LastName}"; }


    public void Work()
    {
      Console.WriteLine("Jisie will give it to them straight.");
    }
  }
}