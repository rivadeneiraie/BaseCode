using Microsoft.AspNetCore.Identity.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore;      
using Entities.Models;

namespace Entities;
public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    // DbSet de tus entidades adicionales
    public DbSet<Product> Products { get; set; }
}