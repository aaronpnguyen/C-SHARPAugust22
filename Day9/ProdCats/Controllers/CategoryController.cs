using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdCats.Models;

namespace ProdCats.Controllers;

public class CategoryController: Controller
{
    private MyContext DATABASE;

    public CategoryController(MyContext db)
    {
        DATABASE = db;
    }

    [HttpGet("/categories")]
    public IActionResult Categories()
    {
        List<Category> AllCategories = DATABASE.Categories.ToList();
        ViewBag.AllCategories = AllCategories;
        return View("Category");
    }

    [HttpPost("/create/category")]
    public IActionResult SubmitCategory(Category newCategory)
    {
        if (!ModelState.IsValid) return Categories();
        DATABASE.Categories.Add(newCategory);
        DATABASE.SaveChanges();
        return Categories();
    }

    [HttpGet("/category/{id}")]
    public IActionResult OneProduct(int id)
    {
        Category? category = DATABASE.Categories
            .Include(category => category.Connections)
            .ThenInclude(connection => connection.Product)
            .FirstOrDefault(category => category.CategoryId == id);
        if (category == null) return Categories();

        // List<Category> notIn = DATABASE.Categories
        //     .Include(category => category.Connections)
        //     .ThenInclude(connection => connection.Product)
        //     .Where(category => category.CategoryId != id)
        //     .ToList();
        // Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        // Console.WriteLine(notIn.Count());
        // Console.WriteLine(notIn[0].Connections[1].Product?.ProductName);
        List<Product> allProducts = DATABASE.Products.ToList();
        List<Product> notProducts = new List<Product>();
        foreach(var item in category.Connections)
        {
            notProducts.Add(item.Product);
        }
        
        List<Product> available = allProducts.Except(notProducts).ToList();
        ViewBag.available = available;
        Console.WriteLine("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");
        Console.WriteLine(available.Count());
        Console.WriteLine(ViewBag.available[0].ProductName);
        Console.WriteLine(available[1].ProductName);
        Console.WriteLine(available[2].ProductName);
        return View("ViewOne", category);
    }
}