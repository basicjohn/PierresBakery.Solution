using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PierresBakery.Breads.Tests
{
  [TestClass]
  public class TestingBread
  {
    [TestMethod]
    public void AddBread_IsBread_String()
    {
      Bread testBread = new Bread("Como");
      Assert.AreEqual("Como", testBread.BreadType);
    }

    [TestMethod]
    public void AddBread_IsPrice_String()
    {
      Bread testBread = new Bread("Como");
      int testPrice = 5;
      Assert.AreEqual(testPrice, testBread.Price);
    }



    [TestMethod]
    public void AddBread_IsQuantity_Int()
    {
      Bread testBread = new Bread("Como");
      int testQuantity = 5;
      Assert.AreEqual(testQuantity, testBread.AddBread(5));
    }
  }
}



