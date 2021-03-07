using ExerciseProject.Models;
using ExerciseProject.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExerciseProject.DataBaseCon
{
    public class DataBaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ExerciseProject;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<ProductCategory> productCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }

    }

}
