using Microsoft.AspNetCore.Mvc;

// Inherits from the abstract base controller class
// Inherits helpful methods for handling HTTP request/response cycle
public class HomeController: Controller
{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpGet("/videos")]
    public IActionResult Videos()
    {   
        List<string> demo = new List<string>
        {
            "test", "test1", "test2"
        };
        ViewBag.demo = demo;
        ViewBag.Title = $"I have {ViewBag.demo.Count} tests";
        return View("Videos");
    }
}