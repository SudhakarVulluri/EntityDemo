using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CognineSales.Models
{
    public class ProductList
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ListPrice { get; set; }
        public int ModelYear { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }

    }
}
