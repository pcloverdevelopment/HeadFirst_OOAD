using System.Collections.Generic;
using System.Linq;

namespace GuitarApp
{
  public class Inventory
  {
    private List<Guitar> _guitars;

    public Inventory()
    {
      _guitars = new List<Guitar>();
    }

    public void AddGuitar(string serialNumber, double price, GuitarSpec guitarSpec)
    {
      Guitar guitar = new Guitar(serialNumber, price, guitarSpec);
      _guitars.Add(guitar);
    }

    public Guitar GetGuitar(string serialNumber)
    {
      return _guitars.Where(g => string.Equals(g.SerialNumber, serialNumber)).FirstOrDefault();
    }

    public List<Guitar> Search(GuitarSpec searchSpec)
    {
      List<Guitar> returnGuitars = new List<Guitar>();

      foreach (var guitar in _guitars)
      {
        // ignore serial number and price since those are unique
        string builder = searchSpec.Builder;
        string model = searchSpec.Model;
        string type = searchSpec.Type;
        string backWood = searchSpec.BackWood;
        string topWood = searchSpec.TopWood;

        GuitarSpec guitarSpec = guitar.GuitarSpec;

        if (guitarSpec.MatchesSpec(searchSpec))
        {
          returnGuitars.Add(guitar);
        }
      }
      return returnGuitars;
    }
  }
}