using Microsoft.EntityFrameworkCore;
using ExamenParcialAPI.Models;
namespace ExamenParcialAPI.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Event> Events { get; set; }  
}