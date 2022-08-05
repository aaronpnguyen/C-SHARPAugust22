using Microsoft.AspNetCore.Mvc;
using Users.Models;

public class UserController: Controller
{
    [HttpGet("/")]
    public IActionResult Index()
    {
        return View("Index");
    }

    [HttpPost("/submit")]
    public IActionResult Result(User userInput)
    {   
        return View("Result", userInput);
    }
}