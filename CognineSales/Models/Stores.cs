using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CognineSales.Models
{
    public class Stores : PersonalDetails
    {
        [Key]
        [ForeignKey("AllUsers")]
        public int StoreId { get; set; }
        public AllUsers AllUsers { get; set; }
        public string Name { get; set; }
        public List<Orders> Orders { get; set; }
        public List<Staff> Staff { get; set; }
    }
}
