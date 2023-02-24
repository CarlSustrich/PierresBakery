using System;
using System.Collections.Generic;

namespace PierresBakery.Models 
{
  public class Bread{
    private int NumberOfBreads;
    public static int CostTotal {get;set;} = 0;
    private static List<Bread> _instances = new List<Bread> {};

  public Bread(int num)
  {
    NumberOfBreads = num;
    _instances.Add(this);
  }

  public static void BreadCost()
  {
    int numBreads = 0;
    CostTotal = 0;
    foreach (Bread order in _instances)
    {
      numBreads += order.NumberOfBreads;
    }
    CostTotal += ((5*numBreads)-(5*(numBreads/3)));
  }

  public static void ClearAll()
  {
    _instances.Clear();
  }
  }
}
