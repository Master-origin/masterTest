using Microsoft.EntityFrameworkCore;
using test_master.Models;

namespace test_master.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }
        public DbSet<User> Users { get; set; }

    }
}
