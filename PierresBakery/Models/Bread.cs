using System;

namespace PierresBakery.Breads
{
  public class Bread
  {
    public string BreadType { get; }
    public int Price { get; }
    public int Quantity { get; }
    public Bread(string breadType)
    {
      BreadType = breadType;
      Price = 5;
      Quantity = 0;
    }

    public int AddBread(int quantity)
    {
      return Quantity + quantity;
    }
  }
}