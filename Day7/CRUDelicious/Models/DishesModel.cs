#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CRUDelicious.Models;

public class Dish
{
    [Key]
    public int DishId {get;set;}
    [Required(ErrorMessage = "is required")]
    [Display(Name = "Chef's Name: ")]
    public string ChefName {get;set;}

    [Required(ErrorMessage = "is required")]
    [Display(Name = "Name of Dish: ")]
    public string DishName {get;set;}

    [Required(ErrorMessage = "is required")]
    [Range(1, int.MaxValue)]
    [Display(Name = "# of Calories: ")]
    public int Calories {get;set;}

    [Required(ErrorMessage = "is required")]
    [Range(1, 5)]
    [Display(Name = "Tastiness: ")]
    public int Tastiness {get;set;}

    [Required(ErrorMessage = "is required")]
    [Display(Name = "Description: ")]
    public string Description {get;set;}

    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;
}