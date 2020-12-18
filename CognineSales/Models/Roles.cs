using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CognineSales.Models
{
    public class Roles
    {
        [Key]
        public int Id { get; set; }
        public string RollName { get; set; }
    }
}
