namespace GuitarApp
{
  public static class WoodStringProvider
  {
    public static string ToString(Wood wood)
    {
      switch (wood)
      {
        case Wood.INDIAN_ROSEWOOD: return "Indian Rosewood";
        case Wood.BRAZILIAN_ROSEWOOD: return "Brazilian Rosewood";
        case Wood.MAHOGANY: return "Mahogany";
        case Wood.MAPLE: return "Maple";
        case Wood.COCOBOLO: return "Cocobolo";
        case Wood.CEDAR: return "Cedar";
        case Wood.ADIRONDACK: return "Adirondack";
        case Wood.ALDER: return "Alder";
        case Wood.SITKA: return "Sitka";
        default: return "unspecified";
      }
    }
  }
}