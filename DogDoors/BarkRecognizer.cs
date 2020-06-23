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

    public void Recognize(string bark)
    {
      Console.WriteLine($"{nameof(BarkRecognizer)}: Heard a '{bark}'\n");
      _door.Open();
    }
  }
}