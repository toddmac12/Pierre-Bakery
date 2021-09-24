using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; set; } = 5;
    public int BreadQuantity { get; set; }

    public Bread(int breadQuantity)
    {
      BreadQuantity = breadQuantity;
    }
    public int TotalBreadPrice()
    {
      int breadDeal = BreadPrice * ((BreadQuantity - (BreadQuantity % 3)) / 3);
      int totalBreadPrice = (BreadQuantity * BreadPrice) - breadDeal;
      return totalBreadPrice;
    }
  }
}