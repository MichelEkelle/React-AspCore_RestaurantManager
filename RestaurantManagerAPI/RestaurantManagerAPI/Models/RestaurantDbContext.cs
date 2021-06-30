using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantManagerAPI.Models
{

    // Il faut penser a aller configurer l'injection de cette classe dans le fichier de conf (startup)
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> option):
            base(option)
        {

        }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<FoodItems> FoodItems { get; set; }
        public DbSet<OrdersItems> OrdersItems  { get; set; }
        public DbSet<OrderMasters> OrderMasters { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<FoodItems>();
            modelBuilder.Entity<FoodItems>().HasData(
                  new FoodItems() { FoodID = 1, FoodName = "Poutine-frites", FoodPrice = Convert.ToDecimal(6.5) },
                  new FoodItems() { FoodID = 2, FoodName = "hot Dog", FoodPrice = Convert.ToDecimal(5.5) },
                  new FoodItems() { FoodID = 3, FoodName = "Salade", FoodPrice = Convert.ToDecimal(2.5) },
                  new FoodItems() { FoodID = 4, FoodName = "Poutine-Poulet-frites", FoodPrice = Convert.ToDecimal(8.0) },
                  new FoodItems() { FoodID = 5, FoodName = "Hambuger", FoodPrice = Convert.ToDecimal(6.5) }
                 );

            modelBuilder.Entity<Customers>().HasData(
                 new Customers() { CustomerID = 1, CustomerName = "Michel Ekelle", },
                 new Customers() { CustomerID = 2, CustomerName = "Aymen Zalila", },
                 new Customers() { CustomerID = 3, CustomerName = "Jerome decary", },
                  new Customers() { CustomerID = 4, CustomerName = "Sophie Goudreau", }
                );


        }
        
    }
}


