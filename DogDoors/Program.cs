using System;

namespace DogDoors
{
  class Program
  {
    static void Main(string[] args)
    {
      DogDoor door = new DogDoor();
      BarkRecognizer recognizer = new BarkRecognizer(door);
      Remote remote = new Remote(door);

      // Adjust console output colors
      Console.BackgroundColor = ConsoleColor.DarkGray;

      // Formatting
      Console.WriteLine("------------------------");

      // Simulate the hardware hearing a bark
      Console.WriteLine("Fido starts barking.\n");
      recognizer.Recognize("Woof");

      Console.WriteLine("Fido has gone outside...\n");

      System.Threading.Thread.Sleep(10000);

      Console.WriteLine("Fido's all done...\n");

      // Simulate the hardware hearing a bark again
      Console.WriteLine("Fido starts barking.\n");
      recognizer.Recognize("Woof");

      Console.WriteLine("Fido's back inside...");

      // Formatting
      Console.WriteLine("------------------------");

      // Change terminal color back to original
      Console.ResetColor();

      Console.ReadKey();
    }
  }
}
