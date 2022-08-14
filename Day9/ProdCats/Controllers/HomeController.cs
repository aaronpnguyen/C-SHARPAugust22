using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProdCats.Models;

namespace ProdCats.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
