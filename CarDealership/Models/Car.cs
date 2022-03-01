using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public static List<Car> _vehicles = new List<Car> {};

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      _vehicles.Add(this);
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }

    public static void LowerCost(List<Car> CarList , int percentage)
    {
      decimal pct = percentage;
      foreach (Car automobile in CarList){
        decimal prc = automobile.Price;
        automobile.SetPrice( Decimal.ToInt32(prc * ( (100m - pct)/100m )) );
      }
    }

    public static void PriceByYear (Car c)
    {
      int year = int.Parse(c.MakeModel.Split(" ")[0]);
      decimal prc = c.Price;

      for (int i = year; i < 2022; i ++ ){
         prc *= 0.96m;
      }

      c.Price = Decimal.ToInt32(prc);
    }
    
    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }

    public static List<Car> GetAll()
    {
      return _vehicles;
    }
  }
}