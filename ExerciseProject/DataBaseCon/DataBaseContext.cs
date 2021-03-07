using ExerciseProject.Models;
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
    }

}
