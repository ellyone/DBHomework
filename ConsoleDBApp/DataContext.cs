using ConsoleDBApp.Entities;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace ConsoleDBApp;

public class DataContext : DbContext
{
    public DbSet<CourseGroup> CoursesGroups { get; set; }
    
    public DbSet<CourseLevel> CoursesLevel { get; set; }
    
    public DbSet<Course> Courses { get; set; }

    public DataContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=AIyUaDFB;Database=postgres");
        base.OnConfiguring(optionsBuilder);
    }
}