#pragma warning disable CS8765
#pragma warning disable CS8603
using System.ComponentModel.DataAnnotations;
namespace ChefDishes.Models;

public class OfAge: ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {   
        int current = DateTime.Now.Year; // Gets current year
        DateTime given = (DateTime)value; // Unbox given value to year
        int age = given.Year - current; // Subtract given.year - current.year
        if (age < 18)
            return new ValidationResult("ur a yungin");
        return ValidationResult.Success;
    }
}