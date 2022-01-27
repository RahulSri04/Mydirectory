using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EMSDemoProject.Models
{

    public class Login
    {
        [Required(ErrorMessage = "Enter your Email ID")]
        [RegularExpression("^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$", ErrorMessage = "Invalid email address")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password  Required")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
