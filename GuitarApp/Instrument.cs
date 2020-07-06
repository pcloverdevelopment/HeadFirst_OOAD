namespace GuitarApp
{
  public class Instrument
  {
    public Instrument(string serialNumber, double price, InstrumentSpec instrumentSpec)
    {
      SerialNumber = serialNumber;
      Price = price;
      InstrumentSpec = instrumentSpec;
    }

    public string SerialNumber { get; private set; }
    public double Price { get; private set; }
    public InstrumentSpec InstrumentSpec { get; private set; }
  }
}