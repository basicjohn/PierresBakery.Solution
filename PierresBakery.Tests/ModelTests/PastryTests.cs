using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierresBakery.Pastries.Tests
{
  [TestClass]
  public class TestingPastry
  {
    [TestMethod]
    public void AddPastry_IsPastry_String()
    {
      Pastry testPastry = new Pastry("Scone");
      Assert.AreEqual("Scone", testPastry.PastryType);
    }
    [TestMethod]
    public void AddPastry_IsPrice_String()
    {
      Pastry testPastry = new Pastry("Scone");
      int testPrice = 2;
      Assert.AreEqual(testPrice, testPastry.Price);
    }
    [TestMethod]
    public void AddPastry_IsQuantity_Int()
    {
      Pastry testPastry = new Pastry("Scone");
      int testQuantity = 5;
      Assert.AreEqual(testQuantity, testPastry.AddPastry(5));
    }
    [TestMethod]
    public void PastrySubtotal_IsSubtotal_Int()
    {
      Pastry testPastry = new Pastry("Scone");
      testPastry.AddPastry(41);
      testPastry.PastrySubtotal();
      int testSubtotal = 69;
      Assert.AreEqual(testSubtotal, testPastry.PastriesSubtotal);
    }
  }
}