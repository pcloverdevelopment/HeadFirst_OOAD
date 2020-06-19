namespace GuitarApp
{
  public static class BuilderStringProvider
  {
    public static string ToString(Builder builder)
    {
      switch (builder)
      {
        case Builder.FENDER: return "Fender";
        case Builder.MARTIN: return "Martin";
        case Builder.GIBSON: return "Gibson";
        case Builder.COLLINGS: return "Collings";
        case Builder.OLSON: return "Olson";
        case Builder.RYAN: return "Ryan";
        case Builder.PRS: return "PRS";
        default: return "Unspecified";
      }
    }
  }
}