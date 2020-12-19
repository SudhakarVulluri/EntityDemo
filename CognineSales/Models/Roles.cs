using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace CognineSales.Models
{
    public class Roles
    {
        public static ClaimsIdentity Admin { get; internal set; }
        [Key]
        public int Id { get; set; }
        public string RollName { get; set; }
    }
}
