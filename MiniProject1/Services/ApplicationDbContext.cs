using Microsoft.EntityFrameworkCore;
using MiniProject1.Models;

namespace MiniProject1.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
                
        }

        public DbSet<Product> Products { get; set; }
    }
}
