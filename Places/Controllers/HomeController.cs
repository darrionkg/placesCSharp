using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [Route("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [Route("/items")]
    public ActionResult Create(string description)
    {
      Place myPlace = new Place(description);
      return View("Index", myPlace);
    }

  }
}
