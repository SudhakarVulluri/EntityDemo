using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EntityDemo.Models
{
    public class EmployeeWorkExperienceDetails
    {
        [Key]
        public string WorkExperienceId { get; set; }
        public string EmployeeId { get; set; }
        public int Number_of_Years { get; set; }
        public string KnownLanguages { get; set; }
        public string ExpertIn { get; set; }
    }
}
