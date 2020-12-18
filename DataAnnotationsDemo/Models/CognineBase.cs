using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAnnotationsDemo.Models
{
    public class CognineBase
    {    
        List<CustomerDetails> customerDetails { get; set; }
        List<RestaurantsDetails> restaurantsDetails { get; set; }
    }
}
