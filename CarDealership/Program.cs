using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 3000, 368792, 1);
      Car yugo = new Car("1980 Yugo Koral", 3990, 56000, 6);
      Car ford = new Car("1988 Ford Country Squire", 15600, 239001, 3);
      Car amc = new Car("1976 AMC Pacer", 3500, 198000, 5);

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };
      Car.PriceByYear(amc);
      Console.WriteLine(amc.GetPrice());

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