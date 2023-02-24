using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.TestTools{
  
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearAll();
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
      Pastry.PastryCost();
      Assert.AreEqual(expectedTotal, Pastry.CostTotal);
    }

    [TestMethod]
    public void PastryCost_CalculateCostWithoutAnyFreePastries_Int()
    {
      int expectedTotal = 6;
      Pastry newPastryOrder = new Pastry(3);
      Pastry.PastryCost();
      Assert.AreEqual(expectedTotal, Pastry.CostTotal);
    }

    [TestMethod]
    public void PastryCost_CalculateEveryFourthFree_Int()
    {
      int expectedTotal = 6;
      Pastry newPastryOrder = new Pastry(4);
      Pastry.PastryCost();
      Assert.AreEqual(expectedTotal, Pastry.CostTotal);
    }

    [TestMethod]
    public void PastryCost_DoesNotCompoundOrderTotals_Int()
    {
      int expectedTotal = 2;
      Pastry newPastryOrder = new Pastry(1);
      Pastry.PastryCost();
      Pastry.PastryCost();
      Assert.AreEqual(expectedTotal, Pastry.CostTotal);
    }
    
  }


}
