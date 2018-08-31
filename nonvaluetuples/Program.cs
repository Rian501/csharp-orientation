using System;
using System.Collections.Generic;

namespace nonvaluetuples
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, Dictionary<string, string> priceToBuy, int amount, double priceToSell) product1 = ("Yo-yo", new Dictionary<string, string>() {{"WOW", "YES"}}, 1, 4.55);

            // Console.WriteLine(product1.Item4);
            Console.WriteLine(product1.priceToBuy["WOW"]);

            // Tuple<string, int, string> testTupe = Tuple.Create("Yes", 1, "Maybe");
            // Console.WriteLine(testTupe.Item1);


            //In Main method, create a list of value tuples that will hold individual grades for a class of students. Each tuple will store the assignment name, the student name, the rank of that score amongst the other assignments, and the number of the grade.
            // List<(string assignment, string student, int rank, double points)> grades = new List<(string, string, int, double)>();
            // Add 5, or more, student grades to the list.
            // Iterate over the list of tuples and calculate the total number of points got by all students on the assignments
            // foreach ((string assignment, string student, int rank, double points) asmt in grades)
            // {
            //     // Logic goes here to look up quantity and amount in each transaction
            // }

        }
    }
}
