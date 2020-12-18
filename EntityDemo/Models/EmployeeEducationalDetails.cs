using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityDemo.Models
{
    public class EmployeeEducationalDetails
    {
        [Key]
        public string EducationDetailsId { get; set; }
        public string EmployeeId { get; set; }
        public string CollegeName { get; set; }
        public string Course { get; set; }
        public string Branch { get; set; }
        public string CGPA { get; set; }
    }
}
