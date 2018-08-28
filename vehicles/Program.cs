using System.Linq;
using System.Collections.Generic;
// Use your knowledge of the Interface Segregation Principle and the Dependency Inversion Principle to convert the code below into a system that is more flexible and extensible to accomodate any kind of vehicle class. Each class should only implement code that it needs.
// Create at least two types of each vehicle (water based, ground based, and air based). I've given you one of each kind.
// Complete the tasks in the comments of the Main() method below.
namespace vehicles
{


  public class Program
  {

    public static void Main()
    {

      // Build a collection of all vehicles that fly
      List<IAeroVehicle> fliers = new List<IAeroVehicle>();
      fliers.Add(new Cessna());
      fliers.Add(new PropPlane());

      // With a single `foreach`, have each vehicle Fly()
      foreach (IAeroVehicle plane in fliers)
      {
        plane.Fly();
      }


      // Build a collection of all vehicles that operate on roads
      List<ITerraVehicle> drivers = new List<ITerraVehicle>(){
          new Motorcycle(),
          new Altima()
    };
      // With a single `foreach`, have each road vehicle Drive()
      foreach (ITerraVehicle vroom in drivers)
      {
        vroom.Drive();
      }


      // Build a collection of all vehicles that operate on water
      List<IAquaVehicle> waterGos = new List<IAquaVehicle>(){
          new JetSki(),
          new PaddleBoard()
    };
      foreach (IAquaVehicle waterThing in waterGos)
      {
        waterThing.Drive();
      }

    }
  }
}