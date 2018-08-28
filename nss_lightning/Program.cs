using System;

namespace nss_lightning
{
  class Program
  {
    static void Main(string[] args)
    {
      Cohort C26 = new Cohort()
      {
        CohortNumber = 26
      };
      Instructor jisie = new Instructor("Jisie", "David");
      Instructor steve = new Instructor("Steve", "Brownlee");
      Student jenn = new Student("Jenn", "Lawson");
      Student jewel = new Student("Jewel", "Ramirez");

      C26.InstructorList.Add(steve);
      C26.InstructorList.Add(jisie);
      C26.StudentList.Add(jewel);
      C26.StudentList.Add(jenn);

      Exercise overlyExcited = new Exercise();
      overlyExcited.Name = "Overly Excited";
      overlyExcited.Language = "JavaScript";
      overlyExcited.GithubUrl = "www.github.com/exercises/OE1";

      Exercise chinook = new Exercise()
      {
        Name = "Chinook",
        Language = "C#"
      };

      steve.assignExercise(jewel, chinook);
      jisie.assignExercise(jewel, overlyExcited);

      foreach (var exercise in jewel.AssignedExercises)
      {
        Console.WriteLine(exercise.assignedBy.Name);
      }
      try
      {
        Console.WriteLine(jewel.preworkCompleted);

      }
      catch (System.Exception ex)
      {

        Console.WriteLine(ex.Message);
      }
    }
  }
}
