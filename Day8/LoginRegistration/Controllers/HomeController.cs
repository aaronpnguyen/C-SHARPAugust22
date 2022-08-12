using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginRegistration.Models;

namespace LoginRegistration.Controllers;

public class HomeController: Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
