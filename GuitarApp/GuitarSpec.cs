namespace GuitarApp
{
  public class GuitarSpec
  {
    public string Builder { get; set; }
    public string Model { get; set; }
    public string Type { get; set; }
    public string BackWood { get; set; }
    public string TopWood { get; set; }
    public int StringCount { get; set; }

    public GuitarSpec(string builder, string model, string type, string backWood, string topWood, int stringCount)
    {
      Builder = builder;
      Model = model;
      Type = type;
      BackWood = backWood;
      TopWood = topWood;
      StringCount = stringCount;
    }

    public bool MatchesSpec(GuitarSpec searchSpec)
    {
      string builder = searchSpec.Builder;
      string model = searchSpec.Model;
      string type = searchSpec.Type;
      string backWood = searchSpec.BackWood;
      string topWood = searchSpec.TopWood;

      if (!searchSpec.Builder.Equals(Builder))
      {
        return false;
      }
      if (!searchSpec.Model.Equals(Model))
      {
        return false;
      }
      if (!searchSpec.Type.Equals(Type))
      {
        return false;
      }
      if (!searchSpec.BackWood.Equals(BackWood))
      {
        return false;
      }
      if (!searchSpec.TopWood.Equals(TopWood))
      {
        return false;
      }
      if (!searchSpec.StringCount.Equals(StringCount))
      {
        return false;
      }

      return true;
    }
  }
}