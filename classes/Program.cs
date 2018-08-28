using System;
using System.Collections.Generic;

namespace classes
{
  class Program
  {
    static void Main(string[] args)
    {
      Company danceBots = new Company("DanceBots Inc.", DateTime.Now);
      Console.WriteLine(danceBots.Name);
      Employee jewel = new Employee("Jewel", "Ramirez", "choreographer", DateTime.Now);
      Employee adelaide = new Employee("Adelaide", "Yoder", "remote controller", DateTime.Now);
      Employee emily = new Employee("Emily", "Venturino", "robot artist", DateTime.Now);

      danceBots.employeeList.Add(adelaide);
      danceBots.employeeList.Add(jewel);
      danceBots.employeeList.Add(emily);

      /*
          Iterate the company's employee list and generate the
          simple report shown above
      */
      danceBots.listOutEmployees();
    }
  }
}
