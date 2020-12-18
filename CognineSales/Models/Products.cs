using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CognineSales.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ModelYear { get; set; }
        public int ListPrice { get; set; }
        [ForeignKey("Brands")]
        public int BrandId { get; set; }
        public Brands Brands { get; set; }
        [ForeignKey("Categories")]
        public int CategoryId { get; set; }
        public Categories Categories { get; set; }
        public List<OrderItems> Order { get; set; }
    }
}
