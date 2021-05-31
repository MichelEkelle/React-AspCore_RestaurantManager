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
    }
}


