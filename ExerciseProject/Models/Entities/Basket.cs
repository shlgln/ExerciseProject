using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Models.Entities
{
    public class Basket
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ProductCount { get; set; }
        public int price { get; set; }
        public int TotalPrice
        {
            get
            {
                return ProductCount * price;
            }
        }
        [ForeignKey("ProductId")]
        public ICollection<Product> Products { get; set; }
    }
}
