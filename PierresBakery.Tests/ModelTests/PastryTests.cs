using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPastryQuantity_ReturnsPastryQuantity_Int()
    {
      int pastryQuantity = 1;
      Pastry newPastry = new Pastry(pastryQuantity);
      int result = newPastry.PastryQuantity;
      Assert.AreEqual(pastryQuantity, result);
    }

    [TestMethod]

    public void
       TotalPastryPrice_ReturnsPastryPriceTimesPastryQuantity_Int()
    {
      int orderPastryQuantity = 1;
      int totalPastryPriceTest = 2;
      Pastry newPastry = new Pastry
      (orderPastryQuantity);
      int totalPastryPrice = newPastry.TotalPastryPrice();
      Assert.AreEqual(totalPastryPriceTest, totalPastryPrice);
    }
    [TestMethod]
    public void TotalPastryPrice_ReturnsPastryDealPrice_Int()
    {
      int orderPastryQuantity = 3;
      int totalPastryPriceTest = 5;
      Pastry newPastry = new Pastry(orderPastryQuantity);

      int totalPastryPrice = newPastry.TotalPastryPrice();

      Assert.AreEqual(totalPastryPriceTest, totalPastryPrice);
    }

  }
}