using Microsoft.AspNetCore.Mvc;

public class HomeController: Controller
{
    [HttpGet("/")]
    public IActionResult Index()
    {
        return View("Index");
    }

    [HttpGet("/projects")]
    public IActionResult Project()
    {
        return View("Projects");
    }

    [HttpGet("/contacts")]
    public IActionResult Contact()
    {
        return View("Contacts");
    }
}