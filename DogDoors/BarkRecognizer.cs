using System;

namespace DogDoors
{
  public class BarkRecognizer
  {
    private readonly DogDoor _door;

    public BarkRecognizer(DogDoor door)
    {
      _door = door;
    }

    public void Recognize(Bark bark)
    {
      Console.WriteLine($"{nameof(BarkRecognizer)}: Heard a '{bark.Sound}'\n");

      bool barkWasAllowed = false;
      foreach (Bark b in _door.AllowedBarks)
      {
        if (b.EqualsBark(bark))
        {
          _door.Open();
          barkWasAllowed = true;
        }
      }

      if (!barkWasAllowed)
      {
        Console.WriteLine("This dog is not allowed.");
      }
    }
  }
}