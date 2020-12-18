using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnnotationsDemo.Models
{
    public class CustomerAddressDetails : AddressDetails
    {
        [ForeignKey("CustomerDetailsId")]
        public int CustomerDetailsId { get; set; }
        public CustomerDetails CustomerDetails { get; set; }
    }
}
