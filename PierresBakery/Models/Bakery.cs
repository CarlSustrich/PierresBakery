using System;
using System.Collections.Generic;
 
namespace PierresBakery.Models 
{
  public abstract class Bakery{
    public int FreebieModifier {get;set;}
    public int CostPerItem {get;set;}
    public int NumberOfItems{get;set;}
    public static int BreadTotal {get;set;} =0;
    public static int PastryTotal {get;set;} = 0;
    private static List<Pastry> _pastryInstances =new List<Pastry>();
    private static List<Bread> _breadInstances = new List<Bread>();

    public static void AddPastry(Pastry pastry)
    {
      _pastryInstances.Add(pastry);
    }

    public static void AddBread(Bread bread)
    {
      _breadInstances.Add(bread);
    }

    public static void CalculateCost()
    {
      int numItems = 0;
      PastryTotal = 0;
      BreadTotal = 0;

      foreach (Bread order in _breadInstances)
      {
        numItems = 0;
        numItems += order.NumberOfItems;
        BreadTotal += ((order.CostPerItem*numItems)-(order.CostPerItem*(numItems/order.FreebieModifier)));
      }
    
      foreach (Pastry order in _pastryInstances)
      {
        numItems = 0;
        numItems += order.NumberOfItems;
        PastryTotal += ((order.CostPerItem*numItems)-(order.CostPerItem*(numItems/order.FreebieModifier)));
      }
    }

    public static void ClearBread()
    {
      _breadInstances.Clear();
    }

    public static void ClearPastry()
    {
      _pastryInstances.Clear();
    }

  }
}
