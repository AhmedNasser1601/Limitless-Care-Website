using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Limitless_Care_Website.Logic.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
    }
}
