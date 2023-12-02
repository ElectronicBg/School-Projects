using Microsoft.EntityFrameworkCore;
using Zoo_MVC.Models;

public class ZooContext : DbContext
{
    public ZooContext(DbContextOptions<ZooContext> options) : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }
    public DbSet<Zoo> Zoos { get; set; }
    public DbSet<Enclosure> Enclosures { get; set; }
    public DbSet<Personnel> Employees { get; set; }
    public DbSet<Visitor> Visitors { get; set; }
    public DbSet<Food> Foods { get; set; }
    public DbSet<Veterinarian> Veterinarians { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Visit> Visits { get; set; }
    public DbSet<EventZoo> EventZoos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Visit>()
                  .HasKey(v => new { v.VisitorId, v.ZooId });

        modelBuilder.Entity<Visit>()
            .HasOne(v => v.Visitor)
            .WithMany(v => v.Visits)
            .HasForeignKey(v => v.VisitorId);

        modelBuilder.Entity<Visit>()
            .HasOne(v => v.Zoo)
            .WithMany(z => z.Visits)
            .HasForeignKey(v => v.ZooId);

        modelBuilder.Entity<EventZoo>()
          .HasKey(ez => new { ez.EventId, ez.ZooId });

        modelBuilder.Entity<EventZoo>()
            .HasOne(ez => ez.Event)
            .WithMany(e => e.EventZoos)
            .HasForeignKey(ez => ez.EventId);

        modelBuilder.Entity<EventZoo>()
            .HasOne(ez => ez.Zoo)
            .WithMany(z => z.EventZoos)
            .HasForeignKey(ez => ez.ZooId);

    }
}
