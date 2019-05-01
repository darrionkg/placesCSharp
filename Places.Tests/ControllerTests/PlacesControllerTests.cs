using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Places.Controllers;
using Places.Models;
using System;

namespace Places.Tests
{
  [TestClass]
  public class PlacesControllerTest
  {
    [TestMethod]
    public void Create_ReturnsCorrectActionType_RedirectToActionResult()
    {
        //Arrange
        PlacesController controller = new PlacesController();

        //Act
        IActionResult view = controller.Create("Portland", "Super cool to the homeless", "a lifetime", "yes", "deets");

        //Assert
        Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectAction_Index()
    {
        //Arrange
        PlacesController controller = new PlacesController();
        RedirectToActionResult actionResult = controller.Create("SoCal", "Really cool and nice out for the homeless", "a lifetime", "yes", "deets") as RedirectToActionResult;

        //Act
        string result = actionResult.ActionName;

        //Assert
        Assert.AreEqual(result, "Index");
    }

  }
}
