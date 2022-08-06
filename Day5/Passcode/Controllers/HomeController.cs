using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Passcodes.Models;

namespace Passcodes.Controllers;

public class HomeController: Controller
{
    [HttpGet("/")]
    public IActionResult Index()
    {   
        int? visits = HttpContext.Session.GetInt32("visits");
        if (visits == null) HttpContext.Session.SetInt32("visits", 1);
        Passcode random = new Passcode();
        return View("index", random);
    }

    [HttpPost("/generate")]
    public IActionResult AddVisit()
    {
        int? updateVisits = HttpContext.Session.GetInt32("visits");
        Console.WriteLine(updateVisits);
        if (updateVisits == null) updateVisits = 1;
        else updateVisits += 1;
        Console.WriteLine(updateVisits);
        HttpContext.Session.SetInt32("visits", (int)updateVisits);
        return RedirectToAction("Index");
    }
}
