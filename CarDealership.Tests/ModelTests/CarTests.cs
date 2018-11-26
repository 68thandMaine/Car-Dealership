using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDealership.Models;
using System.Collections.Generic;
using System;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarTest : IDisposable
  {
    public void Dispose()
    {
      Car.ClearAll();
    }

    [TestMethod]
    public void
    CarConstructor_CreatesInstanceOfCar_Car()
    {
      Car newCar = new Car("Honda", "Crv", 14000, 1300, "Great car, but needs a new coat of paint after driving it through an industrial sized sand blaster accidentally");
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }
  }
}
