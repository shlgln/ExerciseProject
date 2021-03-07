using ExerciseProject.Models.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExerciseProject.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public int? ParentId { get; set; }
        //----
        [ForeignKey("ParentId")]
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
