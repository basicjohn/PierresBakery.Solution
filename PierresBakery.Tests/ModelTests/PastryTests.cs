using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Bread;

namespace Bread.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void AddPastry_IsPastry_String()
    {
      Pastry testPastry = new Pastry("Croissant");
      Assert.AreEqual("Croissant", testBread.Type);
    }


    [TestMethod]
    public void AddPastry_IsPrice_String()
    {
      Pastry testPastry = new Pastry("Como");
      Int testPrice = 5;
      Assert.AreEqual(testPrice, testBread.Price);
    }
  }
}



