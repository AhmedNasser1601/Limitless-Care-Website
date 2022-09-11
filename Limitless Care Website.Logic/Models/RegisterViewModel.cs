using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Unit.Data;

namespace Limitless_Care_Website.Logic.Models
{
    public class RegisterViewModel
    {
        public string ID { get; set; }
        [Required(ErrorMessage = "Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Password)]
        [StringLength(50,ErrorMessage ="Password Must be Atleast 8 Characters",MinimumLength = 8)]
        public string Password { get; set; }
       
        [Required(ErrorMessage = "Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Role { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Nationality { get; set; }
    }
}
