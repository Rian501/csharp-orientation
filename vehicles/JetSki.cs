using System;

namespace vehicles
{
  public class JetSki : IAquaVehicle
  {
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }
    public void Drive()
    {
      Console.WriteLine("The jetski zips through the waves with the greatest of ease");
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