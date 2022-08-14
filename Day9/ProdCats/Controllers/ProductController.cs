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
        Product? product = DATABASE.Products.FirstOrDefault(product => product.ProductId == id);
        if (product == null) return Products();
        return View("ViewOne", product);
    }
}