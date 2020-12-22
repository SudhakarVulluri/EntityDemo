using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CognineSales.Models
{
    public class Staff : PersonalDetails
    {
        [Key]
        [ForeignKey("AllUsers")]
        public int StaffId { get; set; }
        public AllUsers AllUsers { get; set; }
        [Required(ErrorMessage = "Firstname is required")]
        [Column(TypeName = "VARCHAR(30)")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lastname is required")]
        [Column(TypeName = "VARCHAR(30)")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Gender is required")]
        [Column(TypeName = "VARCHAR(10)")]
        public string Gender { get; set; }
        public bool Active { get; set; }
        [ForeignKey("Manager")]
        public int? ManagerId { get; set; }
        public Staff Manager { get; set; }
        [ForeignKey("Stores")]
        [Required]
        public int StoreId { get; set; }
        public Stores Stores { get; set; }
        public List<Staff> Staffs { get; set; }
        public List<Orders> Orders { get; set; }
    }
}
