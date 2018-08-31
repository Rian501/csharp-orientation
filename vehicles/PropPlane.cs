using System;

namespace vehicles
{
  public class PropPlane : IAeroVehicle
  {
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 2;
    public int PassengerCapacity { get; set; } = 2;
    public bool Winged { get; set; } = true;
    public double EngineVolume { get; set; } = 31.1;
    public double MaxAirSpeed { get; set; } = 309.0;

    public void Drive()
    {
      throw new NotImplementedException();
    }

    public void Fly()
    {
      Console.WriteLine("The propellor plane sputters through the sky.");
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