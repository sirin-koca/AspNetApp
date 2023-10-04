using Microsoft.EntityFrameworkCore;
using QuickMvcApp.Models;

namespace QuickMvcApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
