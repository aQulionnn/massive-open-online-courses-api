using Microsoft.EntityFrameworkCore;
using UI.Entities;

namespace UI.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        SeedData();
    }
    
    public DbSet<University> Universities { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Module> Modules { get; set; }
    public DbSet<Lecture> Lectures { get; set; }

    private void SeedData()
    {
        if (!Universities.Any()) 
            Universities.AddRange(UniversityConfiguration.GetData());

        if (!Courses.Any()) 
            Courses.AddRange(CourseConfiguration.GetData());

        if (!Modules.Any()) 
            Modules.AddRange(ModuleConfiguration.GetData());

        if (!Lectures.Any()) 
            Lectures.AddRange(LectureConfiguration.GetData());
        
        SaveChanges();
    }
}