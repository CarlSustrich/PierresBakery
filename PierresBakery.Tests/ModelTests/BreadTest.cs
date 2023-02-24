using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.TestTools{
  
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void MethodName_ExpectedFunction_ExpectedOutput()
    {
      Bread newBreadOrder = new Bread(4);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }
  }


}
