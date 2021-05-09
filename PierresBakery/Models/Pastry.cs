using System;

namespace PierresBakery.Pastries
{
  public class Pastry
  {
    public string PastryType { get; }
    public int Price { get; }
    public int Quantity { get; }
    public Pastry(string pastryType)
    {
      PastryType = pastryType;
      Price = 2;
      Quantity = 0;
    }
  }
}