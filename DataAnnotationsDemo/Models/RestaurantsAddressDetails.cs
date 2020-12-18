using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnnotationsDemo.Models
{
    public class RestaurantsAddressDetails : AddressDetails
    {
        [ForeignKey("RestaurantsDetailsId")]
        public int RestaurantsDetailsId { get; set; }
        public RestaurantsDetails RestaurantsDetails { get; set; }
    }
}
