using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Breads;

namespace Bread.Tests
{
  [TestClass]
  public class BreadTests
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
      Int testPrice = 5;
      Assert.AreEqual(testPrice, testBread.Price);
    }
  }
}



