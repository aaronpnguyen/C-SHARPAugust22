using Microsoft.AspNetCore.Mvc;

public class HomeController: Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        ViewBag.CurrentTime = DateTime.Now;
        return View("Index", ViewBag.CurrentTime);
    }
}