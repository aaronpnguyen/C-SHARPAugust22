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
        if (ModelState.IsValid) return View("Submit", user);
        return View("Index");
    }
}
