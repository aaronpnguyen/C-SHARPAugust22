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
    public IActionResult OneCategory(int id)
    {
        Category? category = DATABASE.Categories
            .Include(category => category.Connections)
            .ThenInclude(connection => connection.Product)
            .FirstOrDefault(category => category.CategoryId == id);
        if (category == null) return Categories();

        List<Product> ProdNotIn = DATABASE.Products
            .Include(product => product.Connections)
            .Where(product => !product.Connections
                .Any(category => category.CategoryId == id))
            .ToList();
        
        ViewBag.cat = category;
        ViewBag.ProdNotIn = ProdNotIn;
        return View("ViewOne");
    }

    [HttpPost("/add/product/category/{id}")]
    public IActionResult Combine(int id, Connection product)
    {
        if (!ModelState.IsValid) return OneCategory(id);
        product.CategoryId = id;
        DATABASE.Connections.Add(product);
        DATABASE.SaveChanges();
        return OneCategory(id);
    }
}