using System;
using System.Collections.Generic;

namespace nss_lightning
{
  public class Student : Person, IPerson, IStudent
  {
    public Computer Computer
    {
      get => throw new System.NotImplementedException();
      set => throw new System.NotImplementedException();
    }
    public double preworkCompleted
    {
      get => throw new System.NotImplementedException();
      set => throw new System.NotImplementedException();
    }
    public Student(string FirstName, string LastName)
    {
      _lastname = LastName;
      _firstname = FirstName;
    }
    public List<(Exercise exercise, Instructor assignedBy, DateTime date)> AssignedExercises { get; } = new List<(Exercise exercise, Instructor assignedBy, DateTime date)>();
  }
}


