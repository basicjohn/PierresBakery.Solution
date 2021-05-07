namespace PierresBakery.Models
{
  public class Bread
  {
    public string BreadType;
    public int Price;
    public int Quantity;
    public Bread(string breadType)
    {
      BreadType = breadType;
      Price = 5;
      Quantity = 1;
    }
  }
}