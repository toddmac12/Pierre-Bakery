using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
 [TestMethod]
    public void GetBreadPrice_ReturnsBreadPrice_Int()
    {
      int breadPrice = 5;
      Bread newBread = new Bread(breadPrice);
      int result = newBread.BreadPrice;
      Assert.AreEqual(breadPrice, result);
    }
 [TestMethod]
    public void GetBreadQuantity_ReturnsBreadQuantity_Int()
    {
      int breadQuantity = 1;
      Bread newBread = new Bread(breadQuantity);
      int result = newBread.BreadQuantity;
      Assert.AreEqual(breadQuantity, result);
    }
 [TestMethod]

    public void
    TotalBreadPrice_ReturnsBreadPriceTimesBreadQuantity_Int()
    {
      int orderBreadQuantity = 1;
      int totalBreadPriceTest = 5;
      Bread newBread = new Bread
      (orderBreadQuantity);
      int totalBreadPrice = newBread.TotalBreadPrice();
      Assert.AreEqual(totalBreadPriceTest, totalBreadPrice);
    }
 [TestMethod]

    public void
    TotalBreadPrice_ReturnsBreadPriceThreeForPriceOfTwo_Int(){
      int totalBreadQuantity = 3;
      int totalBreadPriceTest = 10;
      Bread newBread = new Bread(totalBreadQuantity);
      int totalBreadPrice = newBread.TotalBreadPrice();
      Assert.AreEqual(totalBreadPriceTest, totalBreadPrice);

    }

  }
}
