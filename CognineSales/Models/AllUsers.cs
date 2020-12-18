using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CognineSales.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CognineSales.Models
{
    public class AllUsers
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [ForeignKey("Roles")]
        public int RollId { get; set; }
        public Roles Roles { get; set; }
    }
}
