using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChefDishes.Models;

namespace ChefDishes.Controllers;


public class DishController: Controller
{
    private MyContext DATABASE;

    public DishController(MyContext db)
    {
        DATABASE = db;
    }

    [HttpGet("/all/dishes")]
    public IActionResult AllDishes()
    {
        List<Dish> AllDishes = DATABASE.Dishes.Include(dish => dish.Sous).ToList();
        return View("AllDishes", AllDishes);
    }

    [HttpGet("/add/dish")]
    public IActionResult DishForm()
    {   
        List<Chef> AllChefs = DATABASE.Chefs.ToList();
        ViewBag.ListOfChefs = AllChefs;
        return View("AddForm");
    }

    [HttpPost("/create/dish")]
    public IActionResult SubmitNew(Dish newDish)
    {
        if (!ModelState.IsValid) 
        {
            return DishForm();
        }
        DATABASE.Dishes.Add(newDish);
        DATABASE.SaveChanges();
        return AllDishes();
    }
}