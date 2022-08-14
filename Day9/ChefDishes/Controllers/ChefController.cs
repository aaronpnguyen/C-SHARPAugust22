using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChefDishes.Models;

namespace ChefDishes.Controllers;

public class ChefController: Controller
{
    private MyContext DATABASE;

    public ChefController(MyContext db)
    {
        DATABASE = db;
    }

    [HttpGet("/")]
    public IActionResult AllChefs()
    {
        List<Chef> AllChefs = DATABASE.Chefs.Include(dish => dish.AllDishes).ToList();
        return View("AllChefs", AllChefs);
    }

    [HttpGet("/add/chef")]
    public IActionResult ChefForm()
    {
        return View("AddForm");
    }

    [HttpPost("/create/chef")]
    public IActionResult SubmitNew(Chef newChef)
    {
        if (!ModelState.IsValid) 
        {
            Console.WriteLine(newChef.DoB);
            return ChefForm();
        }
        DATABASE.Chefs.Add(newChef);
        DATABASE.SaveChanges();
        return AllChefs();
    }
}