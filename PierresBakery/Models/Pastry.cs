using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry : Bakery
  {
    public Pastry(int num)
    {
      FreebieModifier = 4;
      CostPerItem = 2;
      NumberOfItems = num;
      AddPastry(this);
    }
  }
}
