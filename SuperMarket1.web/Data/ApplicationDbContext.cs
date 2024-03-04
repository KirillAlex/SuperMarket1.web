using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperMarket1.web.Data;

namespace SuperMarket1.web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SuperMarket1.web.Data.Product> Product { get; set; } = default!;
        public DbSet<SuperMarket1.web.Data.Category> Category { get; set; } = default!;
    }
}
