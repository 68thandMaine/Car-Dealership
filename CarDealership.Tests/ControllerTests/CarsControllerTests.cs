using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CarDealership.Controllers;
using CarDealership.Models;

namespace CarsControllerTests.Test
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
      CarsController controller = new CarsController();
      ActionResult view = controller.Create("Honda", "Crv", 13000, 1300, "Great car, but needs a new coat of paint after driving it through an industrial sized sand blaster accidentally");
      Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }
  }
}
