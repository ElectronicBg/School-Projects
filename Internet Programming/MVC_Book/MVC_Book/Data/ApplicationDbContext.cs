using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using MVC_Book.Models;

namespace MVC_Book.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
    }
}
