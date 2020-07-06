using System.Collections;

namespace GuitarApp
{
  public class InstrumentSpec
  {
    private IDictionary _properties;

    public InstrumentSpec(IDictionary properties)
    {
      if (properties == null)
      {
        _properties = new Hashtable();
      }
      else
      {
        _properties = new Hashtable(properties);
      }
    }

    public object GetProperty(string propertyName)
    {
      return _properties[propertyName];
    }

    public IDictionary GetAllProperties()
    {
      return _properties;
    }

    public bool Matches(InstrumentSpec otherSpec)
    {
      foreach (DictionaryEntry property in otherSpec.GetAllProperties())
      {
        string propertyName = (string)property.Key;
        if (!_properties[propertyName].Equals(otherSpec.GetProperty(propertyName)))
        {
          return false;
        }
      }

      return true;
    }
  }
}