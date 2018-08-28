using System;
using System.Collections.Generic;

namespace nss_lightning
{
  public class Person : IPerson
  {
    protected string _lastname;
    protected string _firstname;
    public string Name { get => $"{_firstname} {_lastname}"; }
    public int Age { get; set; }
  }
}