using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityDemo.Models
{
    public class EmployeeAddressDetails
    {
        [Key]
        public string EmployeeAddressId { get; set; }
        public string EmployeeId { get; set; }
        public string EmployeeStreetName { get; set; }
        public string EmployeeState { get; set; }
        public string EmployeeCountry { get; set; }
        public string AddressStatus { get; set; }

        public EmployeeDetails EmployeeDetails { get; set; }
    }
}
