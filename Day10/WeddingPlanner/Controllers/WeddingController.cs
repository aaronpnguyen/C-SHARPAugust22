using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers;

public class WeddingController: Controller
{
    private MyContext DATABASE;

    private int? id
    {
        get
        {
            return HttpContext.Session.GetInt32("id");
        }
    }

    private bool notLogged
    {
        get
        {
            return id == null;
        }
    }

    public WeddingController(MyContext context)
    {
        DATABASE = context;
    }

    [HttpGet("/wedding/form")]
    public IActionResult WeddingForm()
    {
        if (notLogged) return RedirectToAction("LogReg", "User");
        return View("WeddingForm");
    }

    [HttpPost("/submit/form")]
    public IActionResult SubmitWedding(Wedding newWedding)
    {   
        if (!ModelState.IsValid) return WeddingForm();

        newWedding.UserId = (int)id;
        DATABASE.Weddings.Add(newWedding);
        DATABASE.SaveChanges();
        return RedirectToAction("Dashboard", "User");
    }
}