using Microsoft.EntityFrameworkCore;
using UI.Entities;

namespace UI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<University> Universities { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Module> Modules { get; set; }
    public DbSet<Lecture> Lectures { get; set; }
}