using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpPost("/cars/new")]
    public ActionResult Create(string make, string model, int price, int miles, string note)
    {
      Car myCar = new Car(make, model, price, miles,  note);
      myCar.Save();
      return RedirectToAction("Index");
    }
  }
}
