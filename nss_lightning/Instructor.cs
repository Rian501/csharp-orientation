using System;
using System.Collections.Generic;

namespace nss_lightning
{
  public class Instructor : Person, IPerson
  {

    public Instructor(string FirstName, string LastName)
    {
      _lastname = LastName;
      _firstname = FirstName;
    }
    public void assignExercise(Student student, Exercise exercise)
    {
      student.AssignedExercises.Add((exercise, this, DateTime.Now));
    }
  }
}