using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Car.Controllers;
using Car.Models;

namespace Car.Tests
{
  [TestClass]
  public class CarsObjectTest
  {
    [TestMethod]
      public void CarExists()
      {
          //Arrange
          CarObject newCar = new CarObject();
          newCar.SetMakeModel("Toyota");

          //Act


          //Assert
          Assert.AreEqual("Toyota", newCar.GetMakeModel());
      }
    }
}
