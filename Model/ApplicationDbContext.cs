using cryptonians_api.Model;
using Microsoft.EntityFrameworkCore;

namespace cryptonians_api.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        
    }
}