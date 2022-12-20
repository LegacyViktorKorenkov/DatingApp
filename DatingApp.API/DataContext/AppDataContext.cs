using DatingApp.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DatingApp.API.DataContext;

public class AppDataContext : IdentityDbContext
{
    public DbSet<AppUser> AppUsers { get; set; }

    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
}

