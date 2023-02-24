using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.TestTools{
  
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Bakery.ClearAll();
    }

    [TestMethod]
    public void PastryConstructor_CreateInstance_Pastry()
    {
      Pastry newPastryOrder = new Pastry(4);
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }

    [TestMethod]
    public void PastryCost_SetCostOfSinglePastry_Int()
    {
      int expectedTotal = 2;
      Pastry newPastryOrder = new Pastry(1);
      Bakery.CalculateCost();
      Assert.AreEqual(expectedTotal, Bakery.PastryTotal);
    }

    [TestMethod]
    public void PastryCost_CalculateCostWithoutAnyFreePastries_Int()
    {
      int expectedTotal = 6;
      Pastry newPastryOrder = new Pastry(3);
      Bakery.CalculateCost();
      Assert.AreEqual(expectedTotal, Bakery.PastryTotal);
    }

    [TestMethod]
    public void PastryCost_CalculateEveryFourthFree_Int()
    {
      int expectedTotal = 6;
      Pastry newPastryOrder = new Pastry(4);
      Bakery.CalculateCost();
      Assert.AreEqual(expectedTotal, Bakery.PastryTotal);
    }

    [TestMethod]
    public void PastryCost_DoesNotCompoundOrderTotals_Int()
    {
      int expectedTotal = 2;
      Pastry newPastryOrder = new Pastry(1);
      Bakery.CalculateCost();
      Bakery.CalculateCost();
      Assert.AreEqual(expectedTotal, Bakery.PastryTotal);
    }
    
  }


}
