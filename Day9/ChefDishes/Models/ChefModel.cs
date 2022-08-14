#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefDishes.Models;

public class Chef
{
    [Key]
    public int ChefId {get;set;}

    [Required(ErrorMessage = "is required")]
    [Display(Name = "First Name")]
    public string FirstName {get;set;}
    
    [Required(ErrorMessage = "is required")]
    [Display(Name = "Last Name")]
    public string LastName {get;set;}

    [Required(ErrorMessage = "is required")]
    [OfAge]
    [Display(Name = "Date of Birth")]
    public DateTime DoB {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    
    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    public List<Dish> AllDishes {get;set;} = new List<Dish>();

    public string FullName()
    {
        return $"{FirstName} {LastName}";
    }

    public int Age()
    {
        return DateTime.Now.Year - DoB.Year;
    }
}