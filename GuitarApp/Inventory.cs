using System.Collections.Generic;
using System.Linq;

namespace GuitarApp
{
  public class Inventory
  {
    private List<Instrument> _instruments;

    public Inventory()
    {
      _instruments = new List<Instrument>();
    }

    public void AddInstrument(string serialNumber, double price, InstrumentSpec instrumentSpec)
    {
      Instrument instrument = new Instrument(serialNumber, price, instrumentSpec);

      _instruments.Add(instrument);
    }

    public Instrument GetInstrument(string serialNumber)
    {
      return _instruments.Where(g => string.Equals(g.SerialNumber, serialNumber)).FirstOrDefault();
    }

    public List<Instrument> Search(InstrumentSpec searchSpec)
    {
      List<Instrument> instrumentList = new List<Instrument>();

      foreach (var instrument in _instruments)
      {
        if (instrument != null && instrument.InstrumentSpec.Matches(searchSpec))
        {
          instrumentList.Add(instrument);
        }
      }

      return instrumentList;
    }
  }
}