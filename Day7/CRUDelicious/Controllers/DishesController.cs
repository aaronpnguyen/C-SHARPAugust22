using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
namespace CRUDelicious.Controllers;

public class DishesController: Controller
{
    private DeliciousContext DATABASE;

    public DishesController(DeliciousContext db)
    {
        DATABASE = db;
    }

    [HttpGet("/")]
    public IActionResult AllDishes()
    {
        List<Dish> AllDishes = DATABASE.Dishes.ToList();

        return View("All", AllDishes);
    }

    [HttpGet("/create/dish")]
    public IActionResult CreateForm()
    {
        return View("New");
    }

    [HttpPost("/submit/create")]
    public IActionResult SubmitForm(Dish newDish)
    {
        if (!ModelState.IsValid) return CreateForm();
        DATABASE.Dishes.Add(newDish);
        DATABASE.SaveChanges();
        return AllDishes();
    }

    [HttpGet("/dish/{dishId}")]
    public IActionResult ViewDish(int dishId)
    {
        Dish? dish = DATABASE.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
        if (dish == null) return AllDishes();
        return View("ViewOne", dish);
    }

    [HttpGet("/dish/update/{dishId}")]
    public IActionResult UpdateDish(int dishId)
    {
        Dish? dish = DATABASE.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
        if (dish == null) return AllDishes();
        return View("UpdateDish", dish);
    }

    [HttpPost("/dish/update/submit/{updateId}")]
    public IActionResult SubmitUpdate(int updateId, Dish UpdatedDish)
    {
        if (!ModelState.IsValid) return UpdateDish(updateId);
        Dish? dish = DATABASE.Dishes.FirstOrDefault(dish => dish.DishId == updateId);
        if (dish == null) return AllDishes();
        dish.ChefName = UpdatedDish.ChefName;
        dish.DishName = UpdatedDish.DishName;
        dish.Calories = UpdatedDish.Calories;
        dish.Tastiness = UpdatedDish.Tastiness;
        dish.Description = UpdatedDish.Description;
        dish.UpdatedAt = DateTime.Now;
        
        DATABASE.Dishes.Update(dish);
        DATABASE.SaveChanges();
        return ViewDish(dish.DishId);
    }

    [HttpPost("/dish/delete/{deleteId}")]
    public IActionResult DeleteDish(int deleteId)
    {
        Dish? dish = DATABASE.Dishes.FirstOrDefault(dish => dish.DishId == deleteId);

        if (dish != null)
        {
            DATABASE.Dishes.Remove(dish);
            DATABASE.SaveChanges();
        }
        
        return AllDishes();
    }
}