using Microsoft.AspNetCore.Mvc;
using Car.Models;
using System.Collections.Generic;
using System;

namespace Car.Controllers
{
  public class CarsController : Controller
  {

      [HttpGet("/Cars")]
      public ActionResult Index()
      {
          CarObject newCarObject = new CarObject(Request.Query["make-model"],Request.Query["price"],Request.Query["miles"],Request.Query["color"],Request.Query["description"]);
          // CarObject newCarObject = new CarObject();
          // newCarObject.SetMakeModel(Request.Query["make-model"]);
          // newCarObject.SetPrice(Request.Query["price"]);
          // newCarObject.SetMiles(Request.Query["miles"]);
          // newCarObject.SetColor(Request.Query["color"]);
          // newCarObject.SetDescription(Request.Query["description"]);


          newCarObject.Save();
          // List<CarObject> result = new List<CarObject>();
          return View(CarObject.GetAll());
          // return new EmptyResult();
      }

      [HttpGet("/items/new")]
      public ActionResult CreateForm()
      {
          return View();
      }
  }
}
