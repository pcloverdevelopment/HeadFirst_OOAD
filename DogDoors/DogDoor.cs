using System;

namespace DogDoors
{
  public class DogDoor
  {
    public bool IsOpen { get; set; }

    public DogDoor()
    {
      IsOpen = false;
    }

    public void Open()
    {
      Console.WriteLine("The dog door opens.");
      IsOpen = true;
    }

    public void Close()
    {
      Console.WriteLine("The dog door closes.");
      IsOpen = false;
    }
  }
}