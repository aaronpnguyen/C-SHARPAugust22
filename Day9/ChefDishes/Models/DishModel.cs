#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefDishes.Models;

public class Dish
{
    [Key]
    public int DishId {get;set;}

    [Required(ErrorMessage = "is required")]
    [Display(Name = "Name of Dish")]
    public string DishName {get;set;}

    [Required(ErrorMessage = "is required")]
    [Range(1, int.MaxValue)]
    [Display(Name = "# of Calories")]
    public int? Calories {get;set;}

    [Required(ErrorMessage = "is required")]
    [Range(1, 5)]
    public int? Tastiness {get;set;}

    [Required(ErrorMessage = "is required")]
    public string Description {get;set;}

    [Required(ErrorMessage = "is required")]
    public int ChefId {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;

    public DateTime UpdatedAt {get;set;} = DateTime.Now;

    public Chef? Sous {get;set;}
}