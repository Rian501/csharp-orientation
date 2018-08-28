using System;
using System.Collections.Generic;
using System.Linq;


namespace random
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> randos = new List<int>();
      Random random = new Random();
      for (int i = 0; i < 20; i++)
      {
        randos.Add(random.Next(51));
      }

      //   With the resulting List, populate a new List that contains each number squared.For example, if the original list is 2, 5, 3, 15, the final list will be 4, 25, 9, 225.
      List<int> squaredList = new List<int>();
      foreach (int num in randos)
      {
        Console.WriteLine(num);
        squaredList.Add(num * num);
      }

      foreach (int num in squaredList)
      {
        Console.WriteLine(num);
      }

      // Then remove any number that is odd from the list of squared numbers.
      IEnumerable<int> squaredEvens = from num in squaredList
                                      where num % 2 == 0
                                      select num;

      foreach (int numero in squaredEvens)
      {
        Console.WriteLine(numero);
      }

    }
  }
}
