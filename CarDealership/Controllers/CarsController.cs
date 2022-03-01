using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateCar()
    {
      return View();
    }
    [HttpPost("/cars")]
    public ActionResult Create(string makeModel, int price, int miles)
    {
      Car newCar = new Car(makeModel, price, miles);
      return RedirectToAction("Index");
    }
    
    [HttpGet("/discount")]
    public ActionResult DiscountCar()
    {
      return View();
    }

    [HttpPost("/discount")]
    public ActionResult Discount(int discount)
    {
      Car.LowerCost(Car._vehicles, discount);
      return RedirectToAction("Index");
    }
  }
}