using System.Collections.Generic;

namespace GameSystem.Board
{
  public class Tile
  {
    public List<Unit> Units { get; set; }

    public Tile()
    {
      Units = new List<Unit>();
    }

    public void AddUnit(Unit unit)
    {
      Units.Add(unit);
    }

    public void RemoveUnit(Unit unit)
    {
      Units.Remove(unit);
    }
  }
}