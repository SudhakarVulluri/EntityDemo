using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationsDemo.Models
{
    public class History
    {
        [Key]
        public int HistoryId { get; set; }
        public int RestaurantsDetailsId { get; set; }
        public int CustomerDetailsId { get; set; }
        public int ProductListId { get; set; }
    }
}
