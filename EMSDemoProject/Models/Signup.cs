using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMSDemoProject.Models
{
    [Table("Signup")]
    public class Signup
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "First Name Can't be Empty")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Can't be Empty")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Compare("0", ErrorMessage = "Please select Gender")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Enter your Email ID")]
        [RegularExpression("^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$", ErrorMessage = "Invalid email address")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password  Required")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password not matched")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
