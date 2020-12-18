using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityDemo.Models
{
    public class EmployeeDetails
    {
        [Key]
        public string EmployeeId { get; set; }
        [Column(TypeName ="varchar(20)")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; }
        public EmployeeAddressDetails EmployeeAddressDetails { get; set; }
    }
}
