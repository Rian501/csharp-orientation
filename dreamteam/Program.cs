using System;
using System.Collections.Generic;

namespace dreamteam
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create two groups(i.e.List) that will hold three teammates each. These two lists represent one team that will be the server side team, and one that will be the client side team.

      List<IPerson> serverSide = new List<IPerson>();
      List<IPerson> clientSide = new List<IPerson>();

      Jisie jisie = new Jisie();
      serverSide.Add(jisie);
      // Instantiate one instance of each of your teammates.
      // Put your teammates into the appropriate team.
      // serverSide.Add(ed);
      //       serverSide.Add(eliza);
      //       serverSide.Add(kathy);

      //       clientSide.Add(preeti);
      //       clientSide.Add(mitchell);
      //       clientSide.Add(matt);
      //       Write two foreach loops that iterate over each List and makes each of the teammates do their work.        }
    }
  }
