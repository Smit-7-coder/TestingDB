using Microsoft.EntityFrameworkCore;
using TestingDB.Models;

namespace TestingDB.Config
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
    