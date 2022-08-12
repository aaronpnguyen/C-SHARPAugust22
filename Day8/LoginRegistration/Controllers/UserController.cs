using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginRegistration.Models;

namespace LoginRegistration.Controllers;

public class UserController: Controller
{
    private MyContext DATABASE;

    public UserController(MyContext context)
    {
        DATABASE = context;
    }
    
    // [HttpGet("/")]
    // [HttpGet("/register")]
    // public IActionResult Register()
    // {
    //     return View("Register");
    // }
}