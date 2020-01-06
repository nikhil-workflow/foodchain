using FoodChain.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodChain.Domain.Concrete
{
    //public class FooChainDBInitializer : DropCreateDatabaseAlways<EFDbContext>
    //{
    //    protected override void Seed(EFDbContext context)
    //    {
    //        IList<Product> defaultProducts = new List<Product>();

    //        defaultProducts.Add(new Product() {
    //            Description = "A pizza from America with the taste of Kuntucky Chicken.",
    //            Name = "Ketucky Pizza",
    //            Price = 100,
    //            Size = "Medium",
    //            Status = "Available"
    //        });

    //        defaultProducts.Add(new Product()
    //        {
    //            Description = "Flying pizza from the sky, with taste of banana.",
    //            Name = "Flying Jacob",
    //            Price = 150,
    //            Size = "Medium",
    //            Status = "Available"
    //        });

    //        context.Products.AddRange(defaultProducts);


    //        base.Seed(context);
    //    }
    //}

    public class EFDbContext : DbContext
    {
        //public EFDbContext(): base("FoodChain") 
        //{
        //    Database.SetInitializer(new FooChainDBInitializer());
        //}
        public DbSet<Product> Products { get; set; }
       // public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Orderline> Orderlines { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<ProductToppingOrder> ProductToppingOrders { get; set; }

       /* protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().
              HasMany(c => c.ProductToppings).              
              WithOptional().
              Map(
               m =>
               {
                   m.MapLeftKey("ProductId");
                   m.MapRightKey("ToppingId");
                   m.ToTable("ProductToppings");
               });
        }
        */
    }
}
