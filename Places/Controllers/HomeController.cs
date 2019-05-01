using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Places.Controllers;
using Places.Models;

namespace Places.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Place> testList = new List<Place>();
      return View(testList);
    }

  }
}
