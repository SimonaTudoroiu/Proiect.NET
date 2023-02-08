using Microsoft.EntityFrameworkCore;
using Project_Tudoroiu_Simona_251.Models;

namespace Project_Tudoroiu_Simona_251.Data
{
    public class ProjectContext : DbContext
    {
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Product> Products { get;set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ProductInOrder> ProductsInOrder { get; set; }

        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { 
        
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            //Fluent API
            //One To Many: Promotion -> Product
            modelBuilder.Entity<Product>()
                .HasMany(product => product.Promotions)
                .WithOne(promotion => promotion.DiscountedProduct)
                .OnDelete(DeleteBehavior.Cascade);

            
            //Many To Many: Product -> Order
            modelBuilder.Entity<ProductInOrder>()
                .HasKey(po => new { po.ProductId, po.OrderId});

            modelBuilder.Entity<ProductInOrder>()
                .HasOne<Product>(po => po.Product)
                .WithMany(p => p.ProductInOrders)
                .HasForeignKey(po => po.ProductId);

            modelBuilder.Entity<ProductInOrder>()
                .HasOne<Order>(po => po.Order)
                .WithMany(o => o.ProductInOrders)
                .HasForeignKey(po => po.OrderId);

            //One To Many: Order -> User
            modelBuilder.Entity<User>()
                .HasMany(user => user.Orders)
                .WithOne(order => order.User)
                .OnDelete(DeleteBehavior.Cascade);


            //One To Many: Order -> Address

            modelBuilder.Entity<Order>()
                .HasOne(order => order.Address)
                .WithMany(address => address.Orders)
                .OnDelete(DeleteBehavior.Restrict);

            //One To One: User -> Address
            modelBuilder.Entity<User>()
                .HasOne(user => user.Address)
                .WithOne(address => address.User)
                .HasForeignKey<Address>(address => address.UserId);

            base .OnModelCreating (modelBuilder);
        }
    }

}
