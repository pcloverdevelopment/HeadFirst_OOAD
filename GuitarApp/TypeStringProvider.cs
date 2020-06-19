using System;

namespace GuitarApp
{
  public static class TypeStringProvider
  {
    public static string ToString(Type type)
    {
      switch (type)
      {
        case Type.ACOUSTIC: return "acoustic";
        case Type.ELECTRIC: return "electric";
        default: return "unspecified";
      }
    }
  }
}