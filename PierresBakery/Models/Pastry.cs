using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry : Bakery
  {

    public Pastry(int num)
    {
      FreebieModifier = 3;
      CostPerItem = 5;
      NumberOfItems = num;
      Bakery.AddPastry(this);
    }
  }
}
