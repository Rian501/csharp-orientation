using System;
using System.Collections.Generic;

namespace classes
{

  public class Company
  // Create a custom type for Company.A company has the following properties.
  // The Company class should also have a ListEmployees() method which outputs the name of each employee to the console.
  {

    // Some readonly properties (let's talk about gets, baby)
    // Company name (string)
    public string Name { get; }
    // Date founded (DateTime)
    public DateTime CreatedOn { get; }

    // Employees (List<Employee>)
    // Create a public property for holding a list of current employees
    public List<Employee> employeeList = new List<Employee>();
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    // Class constructor
    public Company(string name, DateTime founded)
    {
      this.Name = name;
      this.CreatedOn = founded;
      this.employeeList = new List<Employee>();
    }
    public void listOutEmployees()
    {
      foreach (Employee employee in employeeList)
      {
        Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as {employee.Title} since {employee.StartDate}");
      }
    }

  }
}