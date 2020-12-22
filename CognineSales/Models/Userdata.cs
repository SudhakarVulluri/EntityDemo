using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CognineSales.Models
{
    public class Userdata :PersonalDetails
    {
        [Required(ErrorMessage ="This field is required")]
        public string Name { get; set; }   //Store Name
        [Required(ErrorMessage = "This field is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public int ManagerId { get; set; } //Staff ManagerId
        [Required(ErrorMessage = "This field is required")]
        public string StoreId { get; set; } // staff storeId
    }
}
