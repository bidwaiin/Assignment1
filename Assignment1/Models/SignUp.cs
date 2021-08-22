using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Assignment1.Attribute;

namespace Assignment1.Models
{
    public class SignUp
    {
        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get;  set; }

        [Required(ErrorMessage = "Please Enter UserName")]
        public string UserName { get;  set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get;  set; }

        [Required(ErrorMessage = "Please Enter ConfirmPassword")]
        [Compare("Password",ErrorMessage ="Password is not matching")]
        public string ConfirmPassword { get; set; }

        [RegularExpression("^[789]\\d{9}$",ErrorMessage ="Invalid number" )]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please Enter Country")]
        public string Country { get;  set; }

        [Required(ErrorMessage = "Please Enter City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter Gender")]
        public string Gender { get; set; }

        [ValidateCheckbox(ErrorMessage = "Please select Terms")]
        public bool Terms { get; set; }
    }
}
