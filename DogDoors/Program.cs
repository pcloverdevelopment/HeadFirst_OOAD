using System;

namespace DogDoors
{
  class Program
  {
    static void Main(string[] args)
    {
      DogDoor door = new DogDoor();
      Remote remote = new Remote(door);
      Console.WriteLine("Fido barks to go outside...");
      remote.PressButton();
      Console.WriteLine("\nFido has gone outside...");
      Console.WriteLine("\nFido's all done...");
      Console.WriteLine("\nFido's back inside...");

      Console.ReadKey();
    }
  }
}
