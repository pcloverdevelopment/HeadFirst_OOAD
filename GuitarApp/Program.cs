using System;
using System.Collections.Generic;
using System.Collections;

namespace GuitarApp
{
  class Program
  {
    static void Main(string[] args)
    {
      // Set up Rick's guitar inventory
      Inventory inventory = new Inventory();
      InitializeInventory(inventory);

      IDictionary properties = new Hashtable();
      properties.Add("builder", Builder.GIBSON);
      properties.Add("backWood", Wood.MAPLE);
      InstrumentSpec clientSpec = new InstrumentSpec(properties);

      List<Instrument> matchingInstruments = inventory.Search(clientSpec);

      if (matchingInstruments != null && matchingInstruments.Count > 0)
      {
        Console.WriteLine("---------------------------------\n");
        Console.WriteLine("Erin, you might like these instruments:\n");

        foreach (var instrument in matchingInstruments)
        {
          InstrumentSpec spec = instrument.InstrumentSpec;

          Console.WriteLine($"We have a {spec.GetProperty("instrumentType")} with the following properties:");

          foreach (DictionaryEntry property in spec.GetAllProperties())
          {
            string propertyName = (string)property.Key;
            if (propertyName.Equals("instrumentType")) continue;
            Console.WriteLine($"   {propertyName}: {spec.GetProperty(propertyName)}");
          }

          Console.WriteLine($"  You can have this {spec.GetProperty("instrumentType")} for ${instrument.Price}\n----");

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
      List<InstrumentSpec> specs = new List<InstrumentSpec>();

      Hashtable h1 = new Hashtable();
      h1.Add("instrumentType", InstrumentType.GUITAR);
      h1.Add("builder", Builder.COLLINGS);
      h1.Add("model", "CJ");
      h1.Add("type", Type.ACOUSTIC);
      h1.Add("numStrings", 6);
      h1.Add("topWood", Wood.INDIAN_ROSEWOOD);
      h1.Add("backWood", Wood.SITKA);
      inventory.AddInstrument("11277", 3999.95, new InstrumentSpec(h1));

      Hashtable h2 = new Hashtable();
      h2.Add("instrumentType", InstrumentType.GUITAR);
      h2.Add("builder", Builder.MARTIN);
      h2.Add("model", "D-18");
      h2.Add("type", Type.ACOUSTIC);
      h2.Add("numStrings", 6);
      h2.Add("topWood", Wood.ADIRONDACK);
      h2.Add("backWood", Wood.MAHOGANY);
      inventory.AddInstrument("122784", 5495.95, new InstrumentSpec(h2));

      Hashtable h3 = new Hashtable();
      h3.Add("instrumentType", InstrumentType.GUITAR);
      h3.Add("builder", Builder.FENDER);
      h3.Add("model", "Stratocastor");
      h3.Add("type", Type.ELECTRIC);
      h3.Add("numStrings", 6);
      h3.Add("topWood", Wood.ALDER);
      h3.Add("backWood", Wood.ALDER);
      inventory.AddInstrument("V95693", 1499.95, new InstrumentSpec(h3));

      Hashtable h4 = new Hashtable();
      h4.Add("instrumentType", InstrumentType.GUITAR);
      h4.Add("builder", Builder.FENDER);
      h4.Add("model", "Stratocastor");
      h4.Add("type", Type.ELECTRIC);
      h4.Add("numStrings", 6);
      h4.Add("topWood", Wood.ALDER);
      h4.Add("backWood", Wood.ALDER);
      inventory.AddInstrument("V91512", 1549.95, new InstrumentSpec(h4));

      Hashtable h5 = new Hashtable();
      h5.Add("instrumentType", InstrumentType.GUITAR);
      h5.Add("builder", Builder.GIBSON);
      h5.Add("model", "SG'61 Reissue");
      h5.Add("type", Type.ELECTRIC);
      h5.Add("numStrings", 6);
      h5.Add("topWood", Wood.MAHOGANY);
      h5.Add("backWood", Wood.MAHOGANY);
      inventory.AddInstrument("82765501", 1890.95, new InstrumentSpec(h5));

      Hashtable h6 = new Hashtable();
      h6.Add("instrumentType", InstrumentType.GUITAR);
      h6.Add("builder", Builder.GIBSON);
      h6.Add("model", "Les Paul");
      h6.Add("type", Type.ELECTRIC);
      h6.Add("numStrings", 6);
      h6.Add("topWood", Wood.MAPLE);
      h6.Add("backWood", Wood.MAPLE);
      inventory.AddInstrument("70108276", 2295.95, new InstrumentSpec(h6));

      Hashtable h7 = new Hashtable();
      h7.Add("instrumentType", InstrumentType.MANDOLIN);
      h7.Add("builder", Builder.GIBSON);
      h7.Add("model", "F5-G");
      h7.Add("type", Type.ACOUSTIC);
      h7.Add("topWood", Wood.MAPLE);
      h7.Add("backWood", Wood.MAPLE);
      inventory.AddInstrument("9019920", 5495.99, new InstrumentSpec(h7));

      Hashtable h8 = new Hashtable();
      h8.Add("instrumentType", InstrumentType.BANJO);
      h8.Add("builder", Builder.GIBSON);
      h8.Add("model", "RB-3");
      h8.Add("type", Type.ACOUSTIC);
      h8.Add("topWood", Wood.MAPLE);
      h8.Add("backWood", Wood.MAPLE);
      inventory.AddInstrument("8900231", 2945.95, new InstrumentSpec(h8));
    }
  }
}
