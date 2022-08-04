using Microsoft.AspNetCore.Mvc;
using Users.Models;

public class UserController: Controller
{   
    [HttpGet("/")]
    public IActionResult Index()
    {   
        string message = "pop cat pop cat pop cat pop cat pop cat pop cat pop cat";
        return View("Index", message);
    }

    [HttpGet("/numbers")]
    public IActionResult Numbers()
    {
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        return View("Numbers", numbers);
    }

    [HttpGet("/user")]
    public IActionResult OneUser()
    {
        User user = new User("Aaron", "Nguyen");
        return View("User", user);
    }

    [HttpGet("/users")]
    public IActionResult Users()
    {
        List<User> users = new List<User>();
        users.Add(new User("Aaron", "Nguyen"));
        users.Add(new User("Winter", "Perrone"));
        users.Add(new User("Brandi", "Babilya"));
        users.Add(new User("Kaija", "Pendergast"));
        users.Add(new User("Jonathan", "Cisneros"));
        users.Add(new User("Froilan", "Abellanosa"));
        return View("Users", users);
    }
}