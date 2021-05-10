namespace PierresBakery.Pastries
{
  public class Pastry
  {
    public string PastryType { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    public int PastriesSubtotal { get; set; }
    public Pastry(string pastryType)
    {
      PastryType = pastryType;
      Price = 2;
      Quantity = 0;
    }

    public int AddPastry(int quantity)
    {
      Quantity = Quantity + quantity;
      return Quantity;
    }

    public void PastrySubtotal()
    {
      // Console.WriteLine(Math.Floor(Quantity / 3));
      int salePastry = Quantity / 3;
      PastriesSubtotal = ((Quantity - salePastry) * Price) + salePastry;
    }
  }
}