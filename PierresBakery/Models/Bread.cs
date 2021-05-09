using System;

namespace PierresBakery.Breads
{
  public class Bread
  {
    public string BreadType { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    public int BreadsSubtotal { get; set; }
    public Bread(string breadType)
    {
      BreadType = breadType;
      Price = 5;
      Quantity = 0;
    }

    public int AddBread(int quantity)
    {
      Quantity = Quantity + quantity;
      return Quantity;
    }

    public void BreadSubtotal()
    {
      // Console.WriteLine(Math.Floor(Quantity / 3));
      int freeBread = Quantity / 3;
      BreadsSubtotal = (Quantity - freeBread) * Price;
    }
  }
}