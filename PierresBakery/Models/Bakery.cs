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



    public List<Bread> BreadInstances
    {
      get 
      {return _breadInstances; }
    }

    public List<Pastry> PastryInstances
    {
      get
      {return _pastryInstances; }
    }

    public static void AddPastry(Pastry pastry)
    {
      PastryInstances.Add(pastry);
    }

    public static void AddBread(Bread bread)
    {
      BreadInstances.Add(bread);
    }

    public static void CalculateCost()
    {
      int numBreads = 0;
      int numPastries = 0;
      PastryTotal = 0;
      BreadTotal = 0;

      foreach (Bread order in BreadInstances)
      {
        numBreads = 0;
        numBreads += order.NumberOfItems;
        BreadTotal += ((order.CostPerItem*numBreads)-(order.CostPerItem*(numBreads/order.FreebieModifier)));
      }
    
      foreach (Pastry order in PastryInstances)
      {
        numPastries = 0;
        numPastries += order.NumberOfItems;
        PastryTotal += ((order.CostPerItem*numBreads)-(order.CostPerItem*(numBreads/order.FreebieModifier)));
      }

    }

    public static void ClearAll()
    {
      PastryInstances.Clear();
      BreadInstances.Clear();
    }
  }
}
