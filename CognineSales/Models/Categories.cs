using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CognineSales.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "CategoryName Name is required")]
        [StringLength(30)]
        public string CategoryName { get; set; }
        public List<Products> Products { get; set; }
    }
}
