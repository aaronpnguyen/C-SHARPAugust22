#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;

namespace Wall.Models;

public class MyContext: DbContext 
{ 
    public MyContext(DbContextOptions options): base(options) {}

    public DbSet<User> Users {get;set;}
    public DbSet<Message> Messages {get;set;}
    public DbSet<Comment> Comments {get;set;}
    public DbSet<Friend> Friends {get;set;}
}