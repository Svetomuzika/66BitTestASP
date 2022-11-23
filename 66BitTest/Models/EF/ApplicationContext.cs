using Microsoft.EntityFrameworkCore;
using _66BitTest.Models.Entites;

namespace _66BitTest.Models.EF
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Footballer> Footballers { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.Migrate();
        }
    }
}
