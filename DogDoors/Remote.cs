using System;
using System.Timers;

namespace DogDoors
{
  public class Remote
  {
    private readonly DogDoor _door;
    private readonly Timer _timer = new Timer(5000);

    public Remote(DogDoor door)
    {
      _door = door;
      _timer.Elapsed += new ElapsedEventHandler(CloseDoorCallBack);
    }

    public void PressButton()
    {
      EnableAutoCloseDoor();

      Console.WriteLine("Pressing the remote control button...");

      if (_door.IsOpen)
      {
        _door.Close();
      }
      else
      {
        _door.Open();
      }
    }

    private void EnableAutoCloseDoor()
    {
      _timer.Enabled = true;
    }

    private void CloseDoorCallBack(object sender, ElapsedEventArgs e)
    {
      _door.Close();
      _timer.Enabled = false;
    }
  }
}