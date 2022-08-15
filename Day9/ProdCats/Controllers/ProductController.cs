using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdCats.Models;

namespace ProdCats.Controllers;

public class ProductController: Controller
{
    private MyContext DATABASE;

    public ProductController(MyContext db)
    {
        DATABASE = db;
    }

    [HttpGet("/")]
    public IActionResult Redirect()
    {
        return RedirectToAction("Products");
    }

    [HttpGet("/products")]
    public IActionResult Products()
    {   
        List<Product> AllProducts = DATABASE.Products.ToList();
        ViewBag.AllProducts = AllProducts;
        return View("Products");
    }

    [HttpPost("/create/product")]
    public IActionResult SubmitNew(Product newProduct)
    {
        if (!ModelState.IsValid) return Products();
        DATABASE.Products.Add(newProduct);
        DATABASE.SaveChanges();
        return Products();
    }

    [HttpGet("/products/{id}")]
    public IActionResult OneProduct(int id)
    {
        Product? product = DATABASE.Products
            .Include(product => product.Connections)
            .ThenInclude(connection => connection.Category)
            .FirstOrDefault(product => product.ProductId == id);
        if (product == null) return Products();

        List<Category> allCategories = DATABASE.Categories.ToList();
        List<Category> notCategories = new List<Category>();
        foreach(Connection item in product.Connections)
        {
            notCategories.Add(item.Category);
        }
        
        List<Category> available = allCategories.Except(notCategories).ToList();
        ViewBag.available = available;
        ViewBag.notCategories = notCategories;
        ViewBag.prod = product;
        return View("ViewOne");
    }

    [HttpPost("/add/category/product/{id}")]
    public IActionResult Combine(int id, Connection category)
    {
        if (!ModelState.IsValid) return OneProduct(id);
        category.ProductId = id;
        DATABASE.Connections.Add(category);
        DATABASE.SaveChanges();
        return OneProduct(id);
    }
}