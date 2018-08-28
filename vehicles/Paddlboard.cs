using System;

namespace vehicles
{
  public class PaddleBoard : IAquaVehicle
  {
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }
    public void Drive()
    {
      Console.WriteLine("Use your arms!");
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