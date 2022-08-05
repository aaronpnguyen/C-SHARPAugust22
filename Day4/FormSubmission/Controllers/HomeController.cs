using Microsoft.AspNetCore.Mvc;
using Users.Models;

namespace MVCTemplate.Controllers;

public class HomeController: Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("user/create")]
    public IActionResult Create(User user)
    {
        if (ModelState.IsValid) return RedirectToAction("Submit");
        return View("Index");
    }

    [HttpGet("/submit")]
    public IActionResult Submit()
    {
        return View("Submit");
    }
}
