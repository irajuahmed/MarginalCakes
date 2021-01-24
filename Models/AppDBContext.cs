using Microsoft.EntityFrameworkCore;

namespace MarginalCakes.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
