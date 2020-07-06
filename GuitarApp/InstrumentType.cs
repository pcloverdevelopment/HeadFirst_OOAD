namespace GuitarApp
{
  public enum InstrumentType
  {
    GUITAR,
    BANJO,
    DOBRO,
    FIDDLE,
    BASS,
    MANDOLIN
  }

  public static class InstrumentTypeUtil
  {
    public static string ToString(this InstrumentType instrumentType)
    {
      switch (instrumentType)
      {
        case InstrumentType.GUITAR: return "Guitar";
        case InstrumentType.BANJO: return "Banjo";
        case InstrumentType.DOBRO: return "Dobro";
        case InstrumentType.FIDDLE: return "Fiddle";
        case InstrumentType.BASS: return "Bass";
        case InstrumentType.MANDOLIN: return "Mandolin";
        default: return "Unspecified";
      }
    }
  }
}