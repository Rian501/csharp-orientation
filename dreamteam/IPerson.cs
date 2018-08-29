namespace dreamteam
{
  public interface IPerson
  {
    string Specialty { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    string Name { get; set; }
    void Work();
  }
}