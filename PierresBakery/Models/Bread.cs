using System;
using System.Collections.Generic;

namespace PierresBakery.Models 
{
  public class Bread : Bakery
  {

    public Bread(int num)
    {
      FreebieModifier = 3;
      CostPerItem = 5;
      NumberOfItems = num;
      Bakery.AddBread(this);
    }
  }
}
