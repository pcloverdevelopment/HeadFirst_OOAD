namespace GuitarApp
{
  public class Guitar
  {
    public string SerialNumber { get; set; }
    public double Price { get; set; }
    public GuitarSpec GuitarSpec { get; set; }

    public Guitar(string serialNumber, double price, GuitarSpec guitarSpec)
    {
      SerialNumber = serialNumber;
      Price = price;
      GuitarSpec = guitarSpec;
    }
  }
}