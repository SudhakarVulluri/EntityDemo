using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CognineSales.Models
{
    public class OrderItems
    {
        public int ItemId { get; set; }
        public string Quantity { get; set; }
        public int ListPrice { get; set; }
        public int Discount { get; set; }
        [ForeignKey("Orders")]
        public int OrderId { get; set; }
        public Orders Orders { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public Products Products { get; set; }
    }
}
