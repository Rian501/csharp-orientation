using System;
using System.Collections.Generic;

namespace tuples
{
  class Program
  {
    static void Main(string[] args)
    {
      List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
      (string product, double price, int quantity) product1 = ("Yo-yo", 9.04, 1);
      (string product, double price, int quantity) product2 = ("firework", 12.45, 20);
      (string product, double price, int quantity) product3 = ("billboard", 4500.15, 1);
      (string product, double price, int quantity) product4 = ("banana", .35, 25);
      (string product, double price, int quantity) product5 = ("water bottle", 1.25, 12);
      transactions.Add(product1);
      transactions.Add(product2);
      transactions.Add(product3);
      transactions.Add(product4);
      transactions.Add(product5);

      //   Iterate over the list of tuples and calculate how many total products you sold today, and what your total revenue was.
      double totPrice = 0;
      int totSold = 0;
      foreach ((string product, double price, int quantity) t in transactions)
      {
        totPrice += t.price;
        totSold += t.quantity;
      }
      Console.WriteLine($"Items sold today: {totSold}");
      Console.WriteLine($"Total revenue: ${totPrice}");
    }
  }
}
