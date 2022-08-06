using Microsoft.AspNetCore.Mvc;
using Users.Models;

namespace MVCTemplate.Controllers;

public class HomeController: Controller
{
    public IActionResult Index()
    {
        return View("Index");
    }

    [HttpPost("user/create")]
    public IActionResult Create(User user)
    {
        if (ModelState.IsValid) return RedirectToAction("Result", user);
        return Index();
    }

    [HttpGet("submit")]
    public IActionResult Result(User user)
    {
        return View("Submit", user);
    }
}
