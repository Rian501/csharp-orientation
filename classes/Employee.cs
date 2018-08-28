using System;
using System.Collections.Generic;

namespace classes
{

  public class Employee
  {
    public string FirstName { get; }
    public string LastName { get; }
    public string Title { get; }
    public DateTime StartDate { get; }
    public Employee(string firstname, string lastname, string title, DateTime startdate)
    {
      this.FirstName = firstname;
      this.LastName = lastname;
      this.Title = title;
      this.StartDate = startdate;
    }
  }
}