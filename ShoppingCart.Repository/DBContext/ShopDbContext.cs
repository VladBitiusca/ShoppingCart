using Microsoft.EntityFrameworkCore;
using ShoppingCart.Repository.Entities;

namespace ShoppingCart.Repository.DBContext
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Basket> Baskets { get; set; }

        public DbSet<Article> Articles { get; set; }

        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Basket>().HasMany(x => x.Articles);

            modelBuilder.Entity<Article>().HasOne(x => x.Basket);
        }
    }
}
