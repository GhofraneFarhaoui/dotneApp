using Microsoft.EntityFrameworkCore;

namespace YourNamespace.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet for your models (e.g., Joke model)
        public DbSet<Jokes> Jokes { get; set; }
    }
}
