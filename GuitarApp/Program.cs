using System;
using System.Collections.Generic;

namespace GuitarApp
{
  class Program
  {
    static void Main(string[] args)
    {
      // Set up Rick's guitar inventory
      Inventory inventory = new Inventory();
      InitializeInventory(inventory);

      GuitarSpec whatErinLikes = new GuitarSpec(
          BuilderStringProvider.ToString(Builder.FENDER),
          "Stratocastor",
          TypeStringProvider.ToString(Type.ELECTRIC),
          WoodStringProvider.ToString(Wood.ALDER),
          WoodStringProvider.ToString(Wood.ALDER),
          6);

      List<Guitar> guitars = inventory.Search(whatErinLikes);

      if (guitars != null && guitars.Count > 0)
      {
        Console.WriteLine("---------------------------------\n");
        Console.WriteLine("Erin, you might like these guitars:\n");

        foreach (var guitar in guitars)
        {
          GuitarSpec guitarSpec = guitar.GuitarSpec;
          string builder = guitarSpec.Builder;
          string model = guitarSpec.Model;
          string type = guitarSpec.Type;
          string backWood = guitarSpec.BackWood;
          string topWood = guitarSpec.TopWood;
          double price = guitar.Price;

          Console.WriteLine($"We have a {builder} {model} {type} guitar:\n {backWood} back and sides,\n {topWood} top.\nYou can have it for only $ {price}!");
          Console.WriteLine("---------------------------------\n");
        }
      }
      else
      {
        Console.WriteLine("Sorry, Erin, we have nothing for you.");
      }

      Console.WriteLine("\n");
    }

    private static void InitializeInventory(Inventory inventory)
    {
      inventory.AddGuitar("11277", 3999.95, new GuitarSpec(BuilderStringProvider.ToString(Builder.COLLINGS),
                  "CJ", TypeStringProvider.ToString(Type.ACOUSTIC),
                  WoodStringProvider.ToString(Wood.INDIAN_ROSEWOOD), WoodStringProvider.ToString(Wood.SITKA), 6));
      inventory.AddGuitar("V95693", 1499.95, new GuitarSpec(BuilderStringProvider.ToString(Builder.FENDER),
                          "Stratocastor", TypeStringProvider.ToString(Type.ELECTRIC),
                          WoodStringProvider.ToString(Wood.ALDER), WoodStringProvider.ToString(Wood.ALDER), 6));
      inventory.AddGuitar("V9512", 1549.95, new GuitarSpec(BuilderStringProvider.ToString(Builder.FENDER),
                          "Stratocastor", TypeStringProvider.ToString(Type.ELECTRIC),
                          WoodStringProvider.ToString(Wood.ALDER), WoodStringProvider.ToString(Wood.ALDER), 6));
      inventory.AddGuitar("122784", 5495.95, new GuitarSpec(BuilderStringProvider.ToString(Builder.MARTIN),
                          "D-18", TypeStringProvider.ToString(Type.ACOUSTIC),
                          WoodStringProvider.ToString(Wood.MAHOGANY), WoodStringProvider.ToString(Wood.ADIRONDACK), 6));
      inventory.AddGuitar("76531", 6295.95, new GuitarSpec(BuilderStringProvider.ToString(Builder.MARTIN),
                          "OM-28", TypeStringProvider.ToString(Type.ACOUSTIC),
                          WoodStringProvider.ToString(Wood.BRAZILIAN_ROSEWOOD), WoodStringProvider.ToString(Wood.ADIRONDACK), 6));
      inventory.AddGuitar("70108276", 2295.95, new GuitarSpec(BuilderStringProvider.ToString(Builder.GIBSON),
                          "Les Paul", TypeStringProvider.ToString(Type.ELECTRIC),
                          WoodStringProvider.ToString(Wood.MAHOGANY), WoodStringProvider.ToString(Wood.MAHOGANY), 6));
      inventory.AddGuitar("82765501", 1890.95, new GuitarSpec(BuilderStringProvider.ToString(Builder.GIBSON),
                          "SG '61 Reissue", TypeStringProvider.ToString(Type.ELECTRIC),
                          WoodStringProvider.ToString(Wood.MAHOGANY), WoodStringProvider.ToString(Wood.MAHOGANY), 6));
      inventory.AddGuitar("77023", 6275.95, new GuitarSpec(BuilderStringProvider.ToString(Builder.MARTIN),
                          "D-28", TypeStringProvider.ToString(Type.ACOUSTIC),
                          WoodStringProvider.ToString(Wood.BRAZILIAN_ROSEWOOD), WoodStringProvider.ToString(Wood.ADIRONDACK), 6));
      inventory.AddGuitar("1092", 12995.95, new GuitarSpec(BuilderStringProvider.ToString(Builder.OLSON),
                          "SJ", TypeStringProvider.ToString(Type.ACOUSTIC),
                          WoodStringProvider.ToString(Wood.INDIAN_ROSEWOOD), WoodStringProvider.ToString(Wood.CEDAR), 6));
      inventory.AddGuitar("566-62", 8999.95, new GuitarSpec(BuilderStringProvider.ToString(Builder.RYAN),
                          "Cathedral", TypeStringProvider.ToString(Type.ACOUSTIC),
                          WoodStringProvider.ToString(Wood.COCOBOLO), WoodStringProvider.ToString(Wood.CEDAR), 6));
      inventory.AddGuitar("6 29584", 2100.95, new GuitarSpec(BuilderStringProvider.ToString(Builder.PRS),
                          "Dave Navarro Signature", TypeStringProvider.ToString(Type.ELECTRIC),
                          WoodStringProvider.ToString(Wood.MAHOGANY), WoodStringProvider.ToString(Wood.MAPLE), 6));
    }
  }
}
