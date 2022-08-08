// Using statements
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Monsters.Models;
namespace Monsters.Controllers;
    
public class HomeController: Controller
{
    private MyContext _context;
     
    // here we can "inject" our context service into the constructor
    public HomeController(MyContext context)
    {
        _context = context;
    }
     
    [HttpGet("")]
    public IActionResult Index()
    {
        // Get all Monsters
        ViewBag.AllUsers = _context.Monsters.ToList();
    
         // Get Monsters with the LastName "Aaron"
         ViewBag.Aarons = _context.Monsters
            .Where(u => u.Name == "Aaron");
 
    	// Get the 5 most recently added Monsters
        ViewBag.MostRecent = _context.Monsters
    	    .OrderByDescending(u => u.CreatedAt)
    	    .Take(5)
    	    .ToList();
 
	    return View();
    }
}  