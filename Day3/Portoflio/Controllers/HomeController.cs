using Microsoft.AspNetCore.Mvc;

public class HomeController: Controller
{
    [HttpGet("/")]
    public string Index()
    {
        return "This is my Index!";
    }
    [HttpGet("/projects")]
    public string Projects()
    {
        return "This is my projects";
    }
    [HttpGet("/contacts")]
    public string Contacts()
    {
        return "This is my Contacts!";
    }
}