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
        [Column(TypeName = "VARCHAR(40)")]
        public String Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [Column(TypeName = "VARCHAR(50)")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [Column(TypeName = "VARCHAR(20)")]
        public string Password { get; set; }
        [ForeignKey("Roles")]
        public int RollId { get; set; }
        public Roles Roles { get; set; }
    }
}
