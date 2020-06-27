namespace DogDoors
{
  public class Bark
  {
    public Bark(string sound)
    {
      Sound = sound;
    }

    public string Sound { get; private set; }

    public bool EqualsBark(object bark)
    {
      Bark otherBark = bark as Bark;

      if (bark != null)
      {
        if (Sound.Equals(otherBark.Sound))
        {
          return true;
        }
      }

      return false;
    }
  }
}