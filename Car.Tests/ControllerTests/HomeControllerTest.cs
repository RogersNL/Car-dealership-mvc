using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Car.Controllers;
using Car.Models;

namespace Car.Tests
{
  [TestClass]
  public class CarsControllerTest
  {
    [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
          //Arrange
          CarsController controller = new CarsController();

          //Act
          IActionResult indexView = controller.Index();

          //Assert
          Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }
    }
}
