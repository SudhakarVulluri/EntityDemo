using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CognineSales.Models
{
    public class Stocks
    {
        [ForeignKey("Stores")]
        public int StoreId { get; set; }
        public Stores Stores { get; set; }
        [ForeignKey("Products")]
        public int ProductId { get; set; }
        public Products Products { get; set; }
        public int Quantity { get; set; }
    }
}
