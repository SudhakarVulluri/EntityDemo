using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationsDemo.Models
{
    public class RestaurantsDetails
    {
        [Key]
        public int RestaurantsDetailsId { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantImage { get; set; }
        public string PhoneNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public List<RestaurantsAddressDetails> RestaurantsAddressDetails { get; set; }
        public List<ProductList> ProductList { get; set; }

    }
}
