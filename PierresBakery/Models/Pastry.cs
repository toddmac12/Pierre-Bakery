using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryPrice { get; set; } = 2;

    public int PastryQuantity {get; set;}

    public Pastry(int pastryQuantity)
    {
    PastryQuantity = pastryQuantity;
    }


  }
}