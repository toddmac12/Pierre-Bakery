using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryPrice { get; set; } = 2;

    public int PastryQuantity { get; set; }

    public Pastry(int pastryQuantity)
    {
      PastryQuantity = pastryQuantity;
    }
    public int TotalPastryPrice()
    {
      if (PastryQuantity % 3 == 0)
      {
        int totalPastryPrice = (PastryQuantity / 3) * 5;
        return totalPastryPrice;
      }
      else if (PastryQuantity % 3 > 0 && PastryQuantity > 3)
      {
        int totalPastryPrice = ((PastryQuantity / 3) * 5) + ((PastryQuantity % 3) * PastryPrice);
        return totalPastryPrice;
      }
      else
      {
        return PastryPrice * PastryQuantity;
      }

    }
  }
}