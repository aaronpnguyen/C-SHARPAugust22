using Microsoft.AspNetCore.Mvc;

public class HomeController: Controller
{
    [HttpGet("/")]
    public IActionResult Index()
    {
        return View("Index");
    }

    [HttpPost("submit")]
    public IActionResult Submit(string name, string locations, string language, string comment)
    {   
        List<string> values = new List<string>{
            name, locations, language, comment
        };
        ViewBag.values = values;
        return View("Result", ViewBag.values);
    }

    // [HttpGet("/result/{Name}/{Location}/{Language}/{Comment}")]
    // public IActionResult Result(string Name, string Location, string Language, string Comment)
    // {
    //     Console.WriteLine(Name);
    //     return View("Result");
    // }
}