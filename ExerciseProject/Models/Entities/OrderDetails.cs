using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Models.Entities
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int ProductCount { get; set; }
        public int ProductPrice { get; set; }
        public int TotalPrice
        {
            get
            {
                return ProductPrice * ProductCount;
            }
        }
        [ForeignKey("ProductId")]
        public ICollection<Product> Products { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }
    }
}
