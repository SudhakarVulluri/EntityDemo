using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationsDemo.Models
{
    public class AddressDetails
    {
        [Key]
        public int AddressDetailsId { get; set; }
        public string StreetName { get; set; }
        public string Pincode { get; set; }
        public string StateName { get; set; }
        public string CountryName { get; set; }
        public string NearPlace { get; set; }
    }
}
