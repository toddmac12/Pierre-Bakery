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
  }
}
