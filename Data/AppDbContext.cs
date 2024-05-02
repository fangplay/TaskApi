using Microsoft.EntityFrameworkCore;
using TaskApi.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Task> Tasks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure Task entity
        modelBuilder.Entity<Task>()
            .Property(t => t.DueDate)
            .HasColumnType("datetime"); // Map DueDate property to datetime type in MySQL
    }
}