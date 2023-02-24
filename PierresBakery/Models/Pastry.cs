using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry{
    public int NumberOfPastries {get;set;}
    public static int CostTotal {get;set;} = 0;
    private static List<Pastry> _instances = new List<Pastry> {};

  public Pastry(int num)
  {
    NumberOfPastries = num;
    _instances.Add(this);
  }

  public static void PastryCost()
  {
    int numPastry = 0;
    CostTotal = 0;
    foreach (Pastry order in _instances)
    {
      numPastry += order.NumberOfPastries;
    }
    CostTotal += ((2*numPastry)-(2*(numPastry/4)));
  }

  }
}
