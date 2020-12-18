using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CognineSales.Models
{
    public class Customer : PersonalDetails
    { 
        [Key]
        [ForeignKey("AllUsers")]
        public int CustomerId { get; set; }
        public AllUsers AllUsers { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        [StringLength(10)]
        public string Gender { get; set; }
        public bool IsActive { get; set; }
        public virtual List<Orders> Orders { get; set; }
    }
}
