using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    private string _description;
    private static List<Place> _instances = new List<Place> {};

    public Place (string description)
    {
      _description = description;
      _instances.Add(this);
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
