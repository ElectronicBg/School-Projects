using Microsoft.EntityFrameworkCore;
using MVC__Fluffy_Duffy_Munchkin_Cats.Models;

namespace MVC__Fluffy_Duffy_Munchkin_Cats.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
        }
        public DbSet<Cat> Cats { get; set; }
    }
}
