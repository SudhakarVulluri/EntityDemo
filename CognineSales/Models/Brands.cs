using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CognineSales.Models
{
    public class Brands
    {
        [Key]
        public int BrandId { get; set; }
        [Required(ErrorMessage = "BrandName Name is required")]
        [StringLength(30)]
        public string BrandName { get; set; }
        public List<Products> Products { get; set; }
    }
}
