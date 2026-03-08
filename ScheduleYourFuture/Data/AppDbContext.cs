using Microsoft.EntityFrameworkCore;
using ScheduleYourFuture.Models;

namespace ScheduleYourFuture.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Service> Services { get; set; }
}