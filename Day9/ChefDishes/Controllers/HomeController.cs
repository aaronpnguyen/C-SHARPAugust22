﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ChefDishes.Models;

namespace ChefDishes.Controllers;

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
