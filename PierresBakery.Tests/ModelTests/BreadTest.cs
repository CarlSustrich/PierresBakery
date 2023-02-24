using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.TestTools{
  
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }

    [TestMethod]
    public void BreadConstructor_CreateInstance_Bread()
    {
      Bread newBreadOrder = new Bread(4);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }

    [TestMethod]
    public void BreadCost_SetCostOfSingleLoaf_Int()
    {
      int expectedTotal = 5;
      Bread newBreadOrder = new Bread(1);
      Bread.BreadCost();
      Assert.AreEqual(expectedTotal, Bread.CostTotal);
    }

    [TestMethod]
    public void BreadCost_CalculateCostWithoutAnyFreeLoaves_Int()
    {
      int expectedTotal = 10;
      Bread newBreadOrder = new Bread(2);
      Bread.BreadCost();
      Assert.AreEqual(expectedTotal, Bread.CostTotal);
    }

    [TestMethod]
    public void BreadCost_CalculateEveryThirdFree_Int()
    {
      int expectedTotal = 10;
      Bread newBreadOrder = new Bread(3);
      Bread.BreadCost();
      Assert.AreEqual(expectedTotal, Bread.CostTotal);
    }

    [TestMethod]
    public void BreadCost_DoesNotCompoundOrderTotals_Int()
    {
      int expectedTotal = 5;
      Bread newBreadOrder = new Bread(1);
      Bread.BreadCost();
      Bread.BreadCost();
      Assert.AreEqual(expectedTotal, Bread.CostTotal);
    }
    
  }


}
