using System;

namespace DogDoors
{
  class Program
  {
    static void Main(string[] args)
    {
      DogDoor door = new DogDoor();
      door.AddAllowedBark(new Bark("rowlf"));
      door.AddAllowedBark(new Bark("rooowlf"));
      door.AddAllowedBark(new Bark("rawlf"));
      door.AddAllowedBark(new Bark("woof"));
      BarkRecognizer recognizer = new BarkRecognizer(door);
      Remote remote = new Remote(door);

      // Adjust console output colors
      Console.BackgroundColor = ConsoleColor.DarkGray;

      // Formatting
      Console.WriteLine("------------------------");

      // Simulate the hardware hearing a bark
      Console.WriteLine("Bruce starts barking.\n");
      recognizer.Recognize(new Bark("rowlf"));

      Console.WriteLine("Bruce has gone outside...\n");

      System.Threading.Thread.Sleep(10000);

      Console.WriteLine("Bruce's all done...\n");
      Console.WriteLine("...but he's stuck outside!\n");

      // Simulate the hardware hear a bark (not Bruce!)
      Bark smallDogBark = new Bark("yip");
      Console.WriteLine("A small dog starts barking.\n");
      recognizer.Recognize(smallDogBark);

      System.Threading.Thread.Sleep(5000);

      // Simulate the hardware hearing a bark again
      Console.WriteLine("Bruce starts barking.");
      recognizer.Recognize(new Bark("rooowlf"));

      Console.WriteLine("Bruce's back inside...");

      // Formatting
      Console.WriteLine("------------------------");

      // Change terminal color back to original
      Console.ResetColor();

      Console.ReadKey();
    }
  }
}
