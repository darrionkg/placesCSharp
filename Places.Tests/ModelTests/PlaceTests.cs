using Microsoft.VisualStudio.TestTools.UnitTesting;
using Places.Models;
using System.Collections.Generic;
using System;

namespace Places.Tests
{
  [TestClass]
  public class PlaceTest : IDisposable
  {

    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("Las Vegas", "Casino land", "6 days", "yes", "We partied hard");
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Walk the dog";
      Place newPlace = new Place(description, "Casino land", "6 days", "yes", "We partied hard");
      string result = newPlace.GetDescription();
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void Find_ReturnsPlaceNumber_Int()
    {
      Place lasVegas = new Place("Las Vegas", "Casino land", "6 days", "yes", "We partied hard");

      Place portland = new Place("Portland", "Super cool to the homeless", "a lifetime", "yes", "deets");

      Place portlandIndex = Place.Find(2);

      Assert.AreEqual(portland, portlandIndex);
    }
  }
}
