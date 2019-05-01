using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    private string _description;
    private int _id;
    private static List<Place> _instances = new List<Place> {};
    private string _placeDescription;

    public Place (string description, string placeDescription)
    {
      _description = description;
      _instances.Add(this);
      _id = _instances.Count;
      _placeDescription = placeDescription;
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

    public int GetId()
    {
      return _id;
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public string GetPlaceDescription()
    {
      return _placeDescription;
    }

  }
}
