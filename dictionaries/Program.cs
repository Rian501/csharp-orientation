using System;
using System.Collections.Generic;


namespace dictionaries
{
  class Program
  {
    static void Main(string[] args)
    {
      double nums = 6752562.345;
      Console.WriteLine(nums.ToString("C"));
      Dictionary<string, string> stocks = new Dictionary<string, string>();
      stocks.Add("GE", "General Electric");
      stocks.Add("CAT", "Caterpillar");
      stocks.Add("BUD", "Budweiser");
      stocks.Add("AAPL", "Apple");
      stocks.Add("GOOG", "Google");
      stocks.Add("LUV", "Southwest");



      List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

      purchases.Add((ticker: "GE", shares: 150, price: 23.21));
      purchases.Add((ticker: "GOOG", shares: 32, price: 17.87));
      purchases.Add((ticker: "GE", shares: 80, price: 19.02));
      purchases.Add((ticker: "BUD", shares: 90, price: 21.02));
      purchases.Add((ticker: "AAPL", shares: 20, price: 210.14));
      purchases.Add((ticker: "LUV", shares: 130, price: 21.14));


      /*
    Define a new Dictionary to hold the aggregated purchase information.
    - The key should be a string that is the full company name.
    - The value will be the valuation of each stock (price*amount)
    */
      Dictionary<string, double> stockValues = new Dictionary<string, double>();

      // Iterate over the purchases and update the valuation for each stock
      foreach ((string ticker, int shares, double price) purchase in purchases)
      {
        string fullCompanyName = stocks[purchase.ticker];
        // Does the company name key already exist in the report dictionary?
        if (stockValues.ContainsKey(fullCompanyName))
        {
          // If it does, update the total valuation
          stockValues[fullCompanyName] += (purchase.shares * purchase.price);
        }
        else
        {
          stockValues[fullCompanyName] = purchase.price * purchase.shares;
          // stockValues.Add(purchase.ticker, purchase.price * purchase.shares);

        }
        // If not, add the new key and set its value
      }
      foreach (KeyValuePair<string, double> stock in stockValues)
      {
        Console.WriteLine($"The stock is {stock.Key} and the value is {stock.Value}");
      }
    }
  }
}
