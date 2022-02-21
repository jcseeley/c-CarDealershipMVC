using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, 1);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, 6);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, 3);
      Car amc = new Car("1976 AMC Pacer", 400, 198000, 5);

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };
      Car.LowerCost(Cars, 30);
      Console.WriteLine(Car.DakarRating(volkswagen));

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> CarsMatchingSearch = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
      }

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("$" + automobile.GetPrice());
      }
    }
  }
}