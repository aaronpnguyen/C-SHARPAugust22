#pragma warning disable CS8618
namespace Users.Models;

public class User
{
    public string Name {get; set;}
    public string Locations {get; set;}
    public string Language {get;set;}
    public string Comment {get;set;}


    // If using a DB, make sure the parameters match the form names
    // Otherwise, a constructor isn't needed most of the time
    public User(string name, string locations, string language, string comment)
    {
        Name = name;
        Locations = locations;
        Language = language;
        Comment = comment;
    }
}