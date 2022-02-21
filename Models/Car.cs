using System;
using System.Collections.Generic;

namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }

    public int Endurance { get; set; }

    public Car(string makeModel, int price, int miles, int endurance)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      Endurance = endurance;
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
    
    public static string DakarRating( Car c ){
      int mileageRating; 
      int dakarRating;
      if (c.Miles > 250000){
        mileageRating = 1;
      } else if ( c.Miles > 150000 ){
        mileageRating = 3;
      } else if (c.Miles > 75000){
        mileageRating = 5;
      } else if (c.Miles > 50000){
        mileageRating = 7;
      } else {
        mileageRating = 10;
      }

      dakarRating = mileageRating + c.Endurance;

      if (dakarRating > 15){
        return "this car will be good at the Dakar Rally!";
      }else if (dakarRating > 12){
        return "this car will be decent at the Dakar Rally!";
      }else if (dakarRating > 9){
        return "this car is pretty meh for rallying, rally at your own risk!";
      }else if (dakarRating > 6){
        return "this car is not good for rallying. It's highly unlikely that you'll finish the race.";
      }else {
        return "DO NOT RALLY THIS CAR! CERTAIN DEATH!";
      }
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
  }
}