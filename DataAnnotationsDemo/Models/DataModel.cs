using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace DataAnnotationsDemo.Models
{
    //We can change [Table("DataAnnotationModel")]
    [Table("DataAnnotationModel")]       
    public class DataModel
    {
        /*<--------------------------------------------------------------------->*/
        [Key]
        //we can avoid this column from scaffoldcode [ScaffoldColumn(false)]
        [ScaffoldColumn(true)]         
        public int EmployeeId { get; set; }
        /*<--------------------------------------------------------------------->*/

        /*<--------------------------------------------------------------------->*/
        //We can Display name in view [DisplayName("Employee Name")]
        [DisplayName("Employee Name")]  
        //We can declared field required validation here [Required(ErrorMessage = "Employee Name is required")]
        [Required(ErrorMessage = "Employee Name is required")]
        //we can declare Stringlength [StringLength(100, MinimumLength = 3)] 
        [StringLength(100, MinimumLength = 3)]
        public String EmpName { get; set; }
        /*<--------------------------------------------------------------------->*/

        /*<--------------------------------------------------------------------->*/
        [Required(ErrorMessage = "Employee Address is required")]
        [StringLength(300)]
        public string Address { get; set; }
        /*<--------------------------------------------------------------------->*/

        /*<--------------------------------------------------------------------->*/
        [Required(ErrorMessage = "Salary is required")]
        //We can specify range [Range(3000, 10000000, ErrorMessage = "Salary must be between 3000 and 10000000")]
        [Range(3000, 10000000, ErrorMessage = "Salary must be between 3000 and 10000000")]
        public int Salary { get; set; }
        /*<--------------------------------------------------------------------->*/

        /*<--------------------------------------------------------------------->*/
        [Required(ErrorMessage = "Please enter your email address")]
        //We can specify the datatype of a property [DataType(DataType.EmailAddress)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        //We can specify the maximum lentgth [MaxLength(50)] 
        [MaxLength(50)]
        //We can specify the minimum lentgth [MinLength(20)]
        //[MinLength(20)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }
        /*<--------------------------------------------------------------------->*/

        /*<--------------------------------------------------------------------->*/
        [RegularExpression("^[0-9]{1,10}$", ErrorMessage = "Please enter valid phonenumber")]
        public string PhoneNumber { get; set; }
        /*<--------------------------------------------------------------------->*/
    }
}
