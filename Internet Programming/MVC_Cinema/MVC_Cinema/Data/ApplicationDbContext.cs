using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Cinema.Models;

namespace MVC_Cinema.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Ticket> Ticktes { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
    }
}