using System.Collections.Generic;

namespace nss_lightning
{
  public class Cohort
  {
    public int CohortNumber;
    public List<Student> StudentList { get; set; } = new List<Student>();
    public List<Instructor> InstructorList { get; set; } = new List<Instructor>();
  }
}