using System;
using System.Collections.Generic;
using System.Timers;

namespace DogDoors
{
  public class DogDoor
  {
    private readonly Timer _timer = new Timer(5000);

    public bool IsOpen { get; set; }
    public List<Bark> AllowedBarks { get; }

    public DogDoor()
    {
      IsOpen = false;
      AllowedBarks = new List<Bark>();
      _timer.Elapsed += new ElapsedEventHandler(CloseDoorCallBack);
    }

    public void AddAllowedBark(Bark bark)
    {
      AllowedBarks.Add(bark);
    }

    public void Open()
    {
      EnableAutoCloseDoor();

      Console.WriteLine("The dog door opens.\n");
      IsOpen = true;
    }

    public void Close()
    {
      Console.WriteLine("The dog door closes.\n");
      IsOpen = false;
    }

    private void EnableAutoCloseDoor()
    {
      _timer.Enabled = true;
    }

    private void CloseDoorCallBack(object sender, ElapsedEventArgs e)
    {
      Close();
      _timer.Enabled = false;
    }
  }
}