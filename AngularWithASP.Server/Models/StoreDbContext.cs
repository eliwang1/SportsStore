using Microsoft.EntityFrameworkCore;

namespace AngularWithASP.Server.Models {
    public class StoreDbContext : DbContext {

        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options) { }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<CartLine> Cartlines => Set<CartLine>();
    }
}
