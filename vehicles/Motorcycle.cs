using System;
// Use your knowledge of the Interface Segregation Principle and the Dependency Inversion Principle to convert the code below into a system that is more flexible and extensible to accomodate any kind of vehicle class. Each class should only implement code that it needs.
// Create at least two types of each vehicle (water based, ground based, and air based). I've given you one of each kind.
// Complete the tasks in the comments of the Main() method below.
namespace vehicles
{
  public class Motorcycle : ITerraVehicle
  {
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;

    public void Drive()
    {
      Console.WriteLine("The motorcycle screams down the highway");
    }


    public void Start()
    {
      throw new NotImplementedException();
    }

    public void Stop()
    {
      throw new NotImplementedException();
    }
  }
}