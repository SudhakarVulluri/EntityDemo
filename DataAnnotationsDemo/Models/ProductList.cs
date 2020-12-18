using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnnotationsDemo.Models
{
    public class ProductList
    {
        [Key]
        public int ProductListId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public string ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        [ForeignKey("RestaurantId")]
        public RestaurantsDetails RestaurantsDetails { get; set; }
    }
}
