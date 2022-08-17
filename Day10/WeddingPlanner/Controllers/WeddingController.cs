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
        if (notLogged) return RedirectToAction("LogReg", "User");
        if (!ModelState.IsValid) return WeddingForm();

        newWedding.UserId = (int)id;
        DATABASE.Weddings.Add(newWedding);
        DATABASE.SaveChanges();
        return RedirectToAction("Dashboard", "User");
    }

    [HttpPost("/delete/wedding/{id}")]
    public IActionResult DeleteWedding(int id)
    {
        if (notLogged) return RedirectToAction("LogReg", "User");

        Wedding? wedding = DATABASE.Weddings.FirstOrDefault(wedding => wedding.WeddingId == id);

        if (wedding != null)
        {
            DATABASE.Weddings.Remove(wedding);
            DATABASE.SaveChanges();
        }

        return RedirectToAction("Dashboard", "User");
    }

    [HttpPost("/add/rsvp/{WedId}")]
    public IActionResult AddRsvp(int WedId, Connection guest)
    {
        guest.WeddingId = WedId;
        guest.UserId = (int)id;
        DATABASE.Connections.Add(guest);
        DATABASE.SaveChanges();
        return RedirectToAction("Dashboard", "User");
    }
    
    [HttpPost("/remove/rsvp/{WedId}")]
    public IActionResult UnRsvp(int WedId)
    {
        Connection? guest = DATABASE.Connections
            .FirstOrDefault(con => con.UserId == (int)id && con.WeddingId == WedId);
        
        if (guest != null)
        {
            DATABASE.Connections.Remove(guest);
            DATABASE.SaveChanges();
        }
        return RedirectToAction("Dashboard", "User");
    }

    [HttpGet("/wedding/{WedId}")]
    public IActionResult ViewOne(int WedId)
    {   
        if (notLogged) return RedirectToAction("LogReg", "User");
        Wedding? wedding = DATABASE.Weddings.FirstOrDefault(wedding => wedding.WeddingId == WedId);

        List<Connection>? guestList = DATABASE.Connections
            .Include(connections => connections.User)
            .Where(connection => connection.WeddingId == WedId)
            .ToList();

        ViewBag.GuestList = guestList;
        return View("ViewOne", wedding);
    }
}